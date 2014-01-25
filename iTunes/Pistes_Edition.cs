using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TagLib;//Utilise pour la lecture des tags ID3

namespace iTunes
{
    public partial class Pistes_Edition : Form
    {
        DataSet1 copieDataSet; // Le DataSet parent est copié, nous effectuons les modifications dans le copie
        TagLib.File id = TagLib.File.Create(Form1.passage_Path); // On créé un nouvel éléments TagLib

        public Pistes_Edition()
        {
            InitializeComponent();
            Text = @"Editer les informations d'un morceau";
        }

        public Pistes_Edition(DataSet1 ds)
        {
            InitializeComponent();
            copieDataSet = ds;
            copieDataSet.AcceptChanges();
        }

        /// <summary>
        /// Chargement des informations de la piste à éditer
        /// </summary>
        private void Pistes_Edition_Load(object sender, EventArgs e)
        {
            FileInfo PisteEditer = new FileInfo(Form1.passage_Path);
            if (PisteEditer.IsReadOnly) 
            { 
                MessageBox.Show("Fichier en lecture seule, aucune edition possible !"); 
                this.Close(); 
            }
            
            else
            {
                if (!String.IsNullOrEmpty(id.Tag.Title)) tb_Titre.Text = id.Tag.Title;
                else tb_Titre.Text = Path.GetFileNameWithoutExtension(Form1.passage_Path);
                
                tb_Artiste.Text = id.Tag.JoinedPerformers;
                tb_Album.Text = id.Tag.Album;
                
                if (id.Tag.Pictures.Length >= 1)
                {
                    var bin = (byte[])(id.Tag.Pictures[0].Data.Data);
                    pictureBox1.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
                }
            }
        }

        /// <summary>
        /// Enregistrement des modifications ID3
        /// </summary>
        private void btn_EnregistrerModif_Click(object sender, EventArgs e)
        {            
            /* Modifications ID3 */
            string album = tb_Album.Text;           
            id.Tag.Title = tb_Titre.Text;        
            string[] tableauDesArtistes = new string[1];
            tableauDesArtistes[0] = tb_Artiste.Text;
            id.Tag.Performers = tableauDesArtistes;        
            id.Tag.Album = tb_Album.Text;
            id.Save();
            
            /* Modifications XML */
            XDocument xmlDoc = XDocument.Load("iTunes_Library.xml");
            var PisteAEditer = (from elt in xmlDoc.Elements("Musiques").Elements("Piste") where elt.Element("Checksum").Value == Form1.passage_Checksum select elt);

            PisteAEditer.First().Element("Titre").Value = tb_Titre.Text;
            PisteAEditer.First().Element("Artiste").Value = tb_Artiste.Text;
            PisteAEditer.First().Element("Album").Value = tb_Album.Text;
            xmlDoc.Save("iTunes_Library.xml");
            
            /* Modifications dans DataGridView */
            copieDataSet.Pistes[Form1.passage_IndexGridView].Titre = album;
            copieDataSet.Pistes[Form1.passage_IndexGridView].Artiste = tb_Artiste.Text;
            copieDataSet.Pistes[Form1.passage_IndexGridView].Album = tb_Album.Text;
            
            /*Mise a jour des tags de lecture*/
            Form1.changement = true;
            this.Close();
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        /// <summary>
        /// Gestion du Drag&Drop
        /// </summary>
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] Drags = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string Drag in Drags)
                {
                    if (Path.GetExtension(Drag) == ".gif" || Path.GetExtension(Drag) == ".png" || Path.GetExtension(Drag) == ".jpeg" || Path.GetExtension(Drag) == ".jpg")
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                }
            }
            
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Gestion de changement d'image d'album
        /// </summary>
        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {     
            string[] Imageloc = (String[])e.Data.GetData(DataFormats.FileDrop);
            TagLib.Id3v2.AttachedPictureFrame image = new TagLib.Id3v2.AttachedPictureFrame();
            image.Data = TagLib.ByteVector.FromPath(Imageloc[0]);      
            id.Tag.Pictures = new TagLib.IPicture[1]{image} ;
            id.Save();
            pictureBox1.ImageLocation = Imageloc[0];
            Form1.changement = true;
        }
    }
}