using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using IrrKlang;//DLL du player
using System.Security.Cryptography;


namespace iTunes
{
    public partial class Form1 : Form
    {
       
        public static int GenerateurID = 0; // Variable pour générer un identifiant unique à chaque morceau     
        public static String passage_Path, passage_Checksum; // Variables de passage pour la fenêtre d'édition
        public static int passage_IndexGridView, passage_Id; // Variables de passage pour les fenêtres enfant
        public static Boolean naviguePlaylist = false, nvlePlaylistAAfficherDansMenu = false;      
        public static string path;//Chemin du morceau en train d'etre joue par le lecteur
        public static bool changement;//Utilise pour savoir si les informations d'une musique on etes editees, permet de mettre a jour les tag a l'ecran
        int length;//Longueur du morceau en lecture
        int index;//Position dans la datatable du morceau en train d'etre joue
        //Variables du player
        ISound S;
        ISoundEngine eng = new ISoundEngine();
        DataTable TableAlbums = new DataTable();    
        
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataSet1.AcceptChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v_lbl_NomApp.Text = "MyTunes"; // Nom de l'application affiché dans le lecteur
            menuStrip1.BackColor = Color.Transparent; // Couleur du menu supérieur          
            XML_Lecture(); // Lecture du XML, ajout dans le DataSet, MaJ de la DataGridView
            ajoutPlaylistsXMLauMenu(false); // Ajout des playlists au menu de gauche sans refresh
            UpdateAlbumList();
            if (dataSet1.Pistes.Rows.Count != 0)  AlbumsNavigate();         
        }       
     
        /// <summary>
        /// Vérifier le Checksum MD5 d'un fichier. Renvoi un booléen à TRUE si trouvé.
        /// </summary>
        private Boolean XML_Ajout_CheckMD5(String checksum)
        {
            XDocument document = XDocument.Load("iTunes_Library.xml"); // Chargement du fichier de bibliothèque
            var pistes = from p in document.Descendants("Piste") select new { Checksum = p.Element("Checksum").Value }; // Récupération du Checksum dans le XML
            Boolean Trouve = false;
            foreach (var p in pistes) if (checksum == p.Checksum) Trouve = true; // Condition et recherche
            return Trouve; 
        }

        /// <summary>
        /// Lecture du XML, vérification de l'existence des fichiers musicaux, copie des données dans le DataSet
        /// </summary>
        private void XML_Lecture()
        {
            List<string> FichiersSupprimes = new List<string>();   // Création d'une liste pour le stockage des musiques introuvables         
            
            if (!File.Exists("iTunes_Library.xml")) // Si le fichier XML de Bibliothèque n'existe pas, on le créé
            {
                XElement XML_Nouveau = new XElement("Musiques");              
                XML_Nouveau.Save("iTunes_Library.xml");
            }

            if (!File.Exists("iTunes_Playlists.xml")) // Si le fichier XML de Playlists n'existe pas, on le créé
            {
                XElement XML_Nouveau = new XElement("Playlists");
                XML_Nouveau.Save("iTunes_Playlists.xml");
            }

            XDocument document = XDocument.Load("iTunes_Library.xml"); // Chargement du fichier XML
            var pistes = from p in document.Descendants("Piste")  // Variable qui stocke chaque élément de chaque piste           
                select new
                    {
                        Id = p.Attribute("id").Value,
                        Titre = p.Element("Titre").Value,
                        Artiste = p.Element("Artiste").Value,
                        Album = p.Element("Album").Value,
                        Genre = p.Element("Genre").Value,
                        Duree = p.Element("Durée").Value,
                        Classement = p.Element("Classement").Value,
                        Chemin = p.Element("Chemin").Value,
                        Checksum = p.Element("Checksum").Value,
                        DateAjout = p.Element("DateAjout").Value,
                        NbLecture = p.Element("NbLecture").Value,
                        DateDerniereLecture = p.Element("DateDerniereLecture").Value
                    };
            foreach (var p in pistes) // Pour chaque élément dans la variable pistes on ajoute le dit élément au DataSet1 si le fichier musical existe
            {
                if (Convert.ToInt32(p.Id) > GenerateurID) GenerateurID = Convert.ToInt32(p.Id);
                TimeSpan t = TimeSpan.FromMilliseconds(Convert.ToInt32(p.Duree));
                string Duree = t.Minutes + ":" + t.Seconds.ToString().PadLeft(2,'0');
                string DerniereLecture;
                if (p.DateDerniereLecture == "dateDerniereLecture") {  DerniereLecture =""; }
                else  DerniereLecture=p.DateDerniereLecture;
                if (File.Exists(p.Chemin)) dataSet1.Pistes.AddPistesRow(p.Titre, p.Artiste, p.Album, Duree, p.Classement, p.Genre, p.Chemin, p.Checksum, p.Id, p.DateAjout, p.NbLecture, DerniereLecture);
                else // Si le fichier musical n'existe pas, on informe l'utilisateur et supprime le noeud concerné dans le XML
                {
                    FichiersSupprimes.Add(p.Titre);
                    XML_SupprimerPiste(p.Checksum);
                    
                }
            }
            
            if (FichiersSupprimes.Count!=0) // Si il y a des fichiers supprimés on les affiche
            {
                MsBoxIntrouvable form = new MsBoxIntrouvable(FichiersSupprimes);
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Méthode déclenchée lors de l'ajout d'un fichier dans la bibliothèque
        /// </summary>
        private void XML_AjoutPiste(String path, XDocument xmlDoc)
        {
            // Variables des éléments musicaux
            string titre = null;
            string artiste = null;
            string album = null;
            
            // Création d'un élément TagLib, nécessaire pour l'utilisation des Tags ID3
            TagLib.File id = TagLib.File.Create(path);
            
            if (String.IsNullOrEmpty(id.Tag.Title)) titre = Path.GetFileNameWithoutExtension(path); // Si le Tag ID3 ne contient pas de titre, on utilise le nom du fichier
            else titre = id.Tag.Title; // Dans le cas contraire, c'est bien l'ID3 que nous utilisons
            
            if (String.IsNullOrEmpty(id.Tag.JoinedPerformers)) artiste = "Artiste Inconnu"; // Même procédé pour l'artiste, si ce n'est que désormais il est remplacé par "Artiste Inconnu"
            else artiste = id.Tag.JoinedPerformers;
            
            if (String.IsNullOrEmpty(id.Tag.Album)) album = "Album Inconnu"; // Même procédé pour l'album si ce n'est que désormais il est remplacé par "Album inconnu"
            else album = id.Tag.Album;      

            if (!XML_Ajout_CheckMD5(ReturnMd5(path))) // On vérifie que le Checksum MD5 que l'on souhaite ajoute n'existe pas
                {                  
                // On ajoute un nouveau noeud au fichier XML    
                xmlDoc.Element("Musiques").Add(
                        new XElement("Piste",
                            new XAttribute("id", ++GenerateurID),
                                new XElement("Titre", titre),
                                new XElement("Artiste", artiste),
                                new XElement("Album", album),
                                new XElement("Genre", id.Tag.FirstGenre),
                                new XElement("Durée", id.Properties.Duration.TotalMilliseconds),
                                new XElement("Classement", "0"),                              
                                new XElement("Chemin", path),
                                new XElement("Checksum", ReturnMd5(path)),
                                new XElement("DateAjout", DateTime.Now.ToString()),
                                new XElement("NbLecture", "0"),
                                new XElement("DateDerniereLecture", "dateDerniereLecture")
                            )
                 );
                    TimeSpan t = TimeSpan.FromMilliseconds(id.Properties.Duration.TotalMilliseconds); // Conversion de temps pour le stockage dans le XML
                    string Duree = t.Minutes + ":" + t.Seconds.ToString().PadLeft(2, '0');
                    dataSet1.Pistes.AddPistesRow(titre, artiste,album, Duree, "0", id.Tag.FirstGenre, path, ReturnMd5(path), GenerateurID.ToString(), DateTime.Now.ToString(), "0", ""); // On ajoute le fichier que l'on souhaite ajouter dans la Bibliothèque au DataSet
                }
                else MessageBox.Show("Ce morceau fait déjà parti de vôtre bibliothèque.", "Ooops..."); // Si le morceau est déjà présent, on informe l'utilisateur                
            dataGridView1.DataSource = dataSet1.Pistes; // On spéficie au dataGridView1 la source des données
            if (dataGridView1.RowCount == 1) { trackBarAlbums.Value = trackBarAlbums.Maximum; trackBarAlbums.Enabled = false; }
            else trackBarAlbums.Enabled = true;
        }

        /// <summary>
        /// Méthode de suppression de morceau
        /// </summary>
        private void XML_SupprimerPiste(String ID_Piste)
        {
            XDocument xmlDoc = XDocument.Load("iTunes_Library.xml"); // Ouverture du fichier XML
            var PisteASupprimer2 = (from elt in xmlDoc.Elements("Musiques").Elements("Piste") where elt.Attribute("id").Value == ID_Piste select elt); // L'ID passé en paramètre nous sert à déterminer quel morceau est à supprimer
            PisteASupprimer2.Remove(); // La piste précédemment sélectionnée est supprimée
            xmlDoc.Save("iTunes_Library.xml"); // On enregistre les modifications apportées au XML
            
        }

        /// <summary>
        /// Méthode de lecture du Checksum MD5 d'un fichier
        /// </summary>
        private string ReturnMd5(string path) 
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-","").ToLower();
                }      
            }
        }

        /// <summary>
        /// Evénement lorsque l'on clique sur une ligne de la DataGridView
        /// </summary>
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Si clic-droit alors on affiche le menu contextuel approprié à la position de la souris
            {
                contextMenuStrip1.Show(System.Windows.Forms.Control.MousePosition);
                dataGridView1.ClearSelection();
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1) this.dataGridView1.Rows[rowSelected].Selected = true;
            }
        }
        
        /// <summary>
        /// Evénement lorsque l'on clique sur le bouton Effacer du menu contextuel
        /// </summary>
        private void clicDroit_effacer_Click(object sender, EventArgs e)
        {
            DeletePistesLectures(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            XML_SupprimerPiste(dataGridView1.SelectedRows[0].Cells[8].Value.ToString()); //Suppression dans le XML
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index); // Suppression dans la DataGridView          
            UpdateAlbumList();
        }

       
        /// <summary>
        /// Méthode d'édition des pistes
        /// </summary>
        private void editerLesInformationsDeLaPisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On enregistre certains paramètres dans des variables globales public auxquelles peuvent accéder les d'autres fenêtres
            passage_Path = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            passage_Checksum = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            passage_IndexGridView = dataGridView1.SelectedRows[0].Index;

            // On créé une nouvelle fenêtre avec certains paramètres
            Pistes_Edition fenetre = new Pistes_Edition(dataSet1);
            fenetre.FormBorderStyle = FormBorderStyle.FixedDialog;
            fenetre.MaximizeBox = false;
            fenetre.MinimizeBox = false;
            fenetre.StartPosition = FormStartPosition.CenterScreen;
            fenetre.ShowDialog();
        }

        /// <summary>
        /// Gestion du Menu latéral des Playlists
        /// </summary>
        private void listView_MenusLateraux_ItemActivate(object sender, EventArgs e)
        {
            switch (listView_MenusLateraux.Items[listView_MenusLateraux.SelectedIndices[0]].Index)
            {
                case 0: // Si l'indice cliqué est à 0, on ne fait rien
                    naviguePlaylist = false;
                    dataGridView1.DataSource = dataSet1.Pistes;
                    break;
                default: // Dans le cas contraire, on affiche le menu contextuel approprié
                    naviguePlaylist = true;
                    lectureXMLPlaylist(listView_MenusLateraux.SelectedItems[0].Text);
                    break;
            }
        }

        /// <summary>
        /// Méthode d'ajout de Playlist
        /// </summary>
        public void ajouterPlaylist(String nom)
        {
            /* Ajout dans le XML */
            XDocument xmlDoc = XDocument.Load("iTunes_Playlists.xml");
            xmlDoc.Element("Playlists").Add(
                        new XElement("Playlist",
                            new XAttribute("nom", nom)
                            )
                    );
            xmlDoc.Save("iTunes_Playlists.xml");
        }

        /// <summary>
        /// Méthode de lecture du XML des Playlists
        /// </summary>
        public void lectureXMLPlaylist(String nom)
        {
            // On réinitilise tout...
            dataSet1.PlaylistSelectionnee.Clear();
            dataSet1.tmp.Clear();     

            /* XML vers DataSet */
            /* Récupération XML */
            XDocument xmlDoc = XDocument.Load("iTunes_Playlists.xml");
            var pistes = (from elt in xmlDoc.Elements("Playlists").Elements("Playlist").Elements("Id_Morceau") 
                          select new {Id_Morceau = elt.Value, Nom = elt.Parent.Attribute("nom").Value});
            
            /* Ajout au DataSet */
            foreach (var p in pistes)
            {
                dataSet1.PlaylistSelectionnee.AddPlaylistSelectionneeRow(p.Id_Morceau, p.Nom);
            }

            var requete =
                from pisteID in dataSet1.Pistes.AsEnumerable()
                join playlistID in dataSet1.PlaylistSelectionnee.AsEnumerable()
                on pisteID.Field<String>("Id") equals
                    playlistID.Field<String>("Id")
                where playlistID.Field<String>("NomPlaylist") == nom
                select new
                    {
                        Id = pisteID.Field<String>("Id"),
                        Titre = pisteID.Field<String>("Titre"),
                        Artiste = pisteID.Field<String>("Artiste"),
                        Album = pisteID.Field<String>("Album"),
                        Genre = pisteID.Field<String>("Genre"),
                        Duree = pisteID.Field<String>("Durée"),
                        Classement = pisteID.Field<String>("Classement"),
                        Chemin = pisteID.Field<String>("Chemin"),
                        Checksum = pisteID.Field<String>("Checksum"),
                        DateAjout = pisteID.Field<String>("DateAjout"),
                        NbLecture = pisteID.Field<String>("NbLecture"),
                        DateDerniereLecture = pisteID.Field<String>("DateDerniereLecture")
                    };

            foreach (var titre in requete) dataSet1.tmp.AddtmpRow(titre.Titre, titre.Artiste, titre.Album, titre.Duree, titre.Classement, titre.Genre, titre.Chemin, titre.Checksum, titre.Id, titre.DateAjout, titre.NbLecture, titre.DateDerniereLecture);
            dataGridView1.DataSource = dataSet1.tmp;
        }

        /// <summary>
        /// Méthode d'ajout des Playlists au Menu latéral, en spécifiant si un refresh doit être fait une fois l'ajout réalisé (initialisation != ajout ultérieur)
        /// </summary>
        private void ajoutPlaylistsXMLauMenu(Boolean refresh)
        {
            if (refresh == true)
            {
                foreach (ListViewItem item in listView_MenusLateraux.Items)
                {
                    if (item.Group.Name == "listViewGroup2") item.Remove();
                }
            }
            
            XDocument xmlDoc = XDocument.Load("iTunes_Playlists.xml");
            var nomsDesPlaylists = (from elt in xmlDoc.Elements("Playlists").Elements("Playlist") select elt.Attribute("nom").Value);
            foreach (var nom in nomsDesPlaylists)
            {
                ListViewGroup v_mesPlaylists = listView_MenusLateraux.Groups[1];
                listView_MenusLateraux.Items.Add(new ListViewItem() { Text = nom.ToString(), Group = v_mesPlaylists });           
            }

        }

        private void ajouterDansPlaylist_Click(object sender, EventArgs e)
        {
            passage_Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value);
            AjoutMorceauDansPlaylist fenetre = new AjoutMorceauDansPlaylist();
            fenetre.FormBorderStyle = FormBorderStyle.FixedDialog;
            fenetre.MaximizeBox = false;
            fenetre.MinimizeBox = false;
            fenetre.StartPosition = FormStartPosition.CenterScreen;
            fenetre.ShowDialog();
            if (nvlePlaylistAAfficherDansMenu == true)
            {
                ajoutPlaylistsXMLauMenu(true);
                nvlePlaylistAAfficherDansMenu = false;
            }
        }

        /// <summary>
        /// Evénement lors du clic-droit sur le nom d'une Playlist dans le menu latéral
        /// </summary>
        private void listView_MenusLateraux_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && listView_MenusLateraux.SelectedItems[0].Group.Name == "listViewGroup2")
            {
                contextMenuStrip2.Show(Control.MousePosition);              
            }         
        }

        /// <summary>
        /// Méthode de suppression de Playlist depuis le menu contextuel d'une Playlist du menu latéral
        /// </summary>
        private void supprimerLaPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String nomDePlaylist = listView_MenusLateraux.SelectedItems[0].Text;

            /* Suppression du Menu */
            foreach (ListViewItem item in listView_MenusLateraux.Items)
            {
                if (item.Text == nomDePlaylist) item.Remove();
            }
            
            /* Suppression XML */
            XDocument xmlDoc = XDocument.Load("iTunes_Playlists.xml");
            var PlaylistASupprimer = (from elt in xmlDoc.Elements("Playlists").Elements("Playlist") where elt.Attribute("nom").Value == nomDePlaylist select elt);
            PlaylistASupprimer.Remove();
            xmlDoc.Save("iTunes_Playlists.xml"); 

            /* Message de confirmation */
            MessageBox.Show("La Playlist a bien été supprimée.");
        }

        /// <summary>
        /// Méthode de mise à jour des données de lecture (date de dernière lecture, nombre de lecture)
        /// </summary>
        private void majDonneesLecture(String id_xml, int indexGV)
        {
            /* Modifications XML */
            XDocument xmlDoc = XDocument.Load("iTunes_Library.xml");
            var PisteAEditer = (from elt in xmlDoc.Elements("Musiques").Elements("Piste") where elt.Attribute("id").Value == id_xml select elt);
            PisteAEditer.First().Element("NbLecture").Value = (Convert.ToInt32(PisteAEditer.First().Element("NbLecture").Value)+1).ToString();
            PisteAEditer.First().Element("DateDerniereLecture").Value = DateTime.Now.ToString();
            xmlDoc.Save("iTunes_Library.xml");
            
            /* Modifications dans DataGridView */
            dataSet1.Pistes[indexGV].NbLecture = (Convert.ToInt32(dataSet1.Pistes[indexGV].NbLecture)+1).ToString();
            dataSet1.Pistes[indexGV].DateDerniereLecture = DateTime.Now.ToString();
        }

        /// <summary>
        /// Une fois que le classement a été saisi, on l'enregistre dans le xML
        /// </summary>
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {            
            /* Modifications XML */
            XDocument xmlDoc = XDocument.Load("iTunes_Library.xml");
            var PisteAEditer = (from elt in xmlDoc.Elements("Musiques").Elements("Piste") where elt.Attribute("id").Value == dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString() select elt);
            PisteAEditer.First().Element("Classement").Value = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            xmlDoc.Save("iTunes_Library.xml");
        }

        /// <summary>
        /// Ajout de pistes grace au bouton d'ajout
        /// </summary>
        private void ajouterLeFichierÀLaBibliothèqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XDocument xmlDoc = XDocument.Load("iTunes_Library.xml");
                foreach (string file in ofd.FileNames)
                {
                    if(Path.GetExtension(file)==".mp3")
                    XML_AjoutPiste(file, xmlDoc);
                }
                xmlDoc.Save("iTunes_Library.xml");
                UpdateAlbumList();
            }
        }

        /// <summary>
        /// Lecture d'une piste quand l'utilisateur double click sur une ligne
        /// </summary>
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdatePistesLecture(dataGridView1);
            PlayMusic(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            
            majDonneesLecture(dataGridView1.SelectedRows[0].Cells[8].Value.ToString(), dataGridView1.SelectedRows[0].Index);
            
            index = dataGridView1.SelectedRows[0].Index;
        }

        /// <summary>
        /// Seek
        /// </summary>
        private void trackBarPlay_Scroll(object sender, EventArgs e)
        {
            S.PlayPosition = Convert.ToUInt32(trackBarPlay.Value * 1000);
        }

        /// <summary>
        /// Pause la lecture lorsque l'utilisateur utilise la trackbar
        /// </summary>
        private void trackBarPlay_MouseDown(object sender, MouseEventArgs e)
        {
            eng.SetAllSoundsPaused(true);
        }

        /// <summary>
        /// Et continue de jouer quand il a fini
        /// </summary>
        private void trackBarPlay_MouseUp(object sender, MouseEventArgs e)
        {
            eng.SetAllSoundsPaused(false);
        }

        /// <summary>
        /// Timer
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            float volume = (float)trackBarVol.Value / 100;
            float a = volume * 100;
            eng.SoundVolume = volume;
            int pos;
            if (path != null)
            {//Met a jour tous les tag si un morceau est en train d'etre joue
                pos = Convert.ToInt32(S.PlayPosition / 1000);                
                trackBarPlay.Value = pos;
                int secondes = pos % 60;
                int minutes = pos / 60;
                if (secondes < 10) { labelAvt.Text = minutes.ToString() + ":0" + secondes.ToString(); }
                else labelAvt.Text = minutes.ToString() + ":" + secondes.ToString();
                int secondes2 = (length-pos) % 60;
                int minutes2 = (length-pos) / 60;
                if (secondes2 < 10) { labelAprs.Text ="-"+minutes2.ToString() + ":0" + secondes2.ToString(); }
                else labelAprs.Text = "-"+minutes2.ToString() + ":" + secondes2.ToString();

                if (S.Finished)
                {
                    //Passe au prochain morceau si celui la a fini de jouer
                    if (index != dataSet1.PistesLecture.Rows.Count - 1)
                        PlayMusic(dataSet1.PistesLecture.Rows[++index][1].ToString());
                    else
                    {
                        index = 0;
                        PlayMusic(dataSet1.PistesLecture.Rows[index][1].ToString());
                    }


                }
            }

            if (path == null)//Activation ou non des bouton en fonction de l'etat du player
            {
                
                checkBoxPlay.Enabled = false;
                BtnStop.Enabled = false;
                trackBarVol.Enabled = false;
                trackBarPlay.Enabled = false;
                BtnPrec.Enabled = false;
                BtnSuiv.Enabled = false;
            }
            
            else
            {
                
                checkBoxPlay.Enabled = true;
                BtnStop.Enabled = true;
                trackBarPlay.Enabled = true;
                trackBarVol.Enabled = true;
                BtnPrec.Enabled = true;
                BtnSuiv.Enabled = true;
                
            }
            
            //Met a jour les tags 
            if (changement == true) 
            { 
                changement = false; 
                UpdateTags(); 
                updateAlbumPicture(); 
                UpdateAlbumList(); 
            }
        }

        /// <summary>
        // Play-Pause
        /// </summary>       
        private void checkBoxPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (path != null)
            {
                if (checkBoxPlay.Checked) 
                {
                    checkBoxPlay.Image = new Bitmap("img/btnplay.png");
                    eng.SetAllSoundsPaused(true);
                   
                }
                else
                {
                    
                    checkBoxPlay.Image = new Bitmap("img/btnpause.png");
                    eng.SetAllSoundsPaused(false);
                }
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            eng.SetAllSoundsPaused(true);
            checkBoxPlay.Checked = true;
            S.PlayPosition = 0;       
        }

        /// <summary>
        /// Joue une musique
        /// </summary>
        private void PlayMusic(string chemin)
        {  
            /* Fichier vers Mémoire */
            FileStream inStream = File.OpenRead(chemin);
            MemoryStream storeStream = new MemoryStream();
            storeStream.SetLength(inStream.Length);
            inStream.Read(storeStream.GetBuffer(), 0, (int)inStream.Length);
            inStream.Close();
            
            eng.RemoveAllSoundSources();
            ISoundSource source = eng.AddSoundSourceFromIOStream(storeStream, "buffer"+Path.GetExtension(chemin));

            /* Design */
            v_lbl_NomApp.Visible = false;
            v_lbl_Titre.Visible = true;
            v_lbl_ArtisteEtAlbum.Visible = true;
            
            trackBarPlay.Visible = true;
            trackBarVol.Visible = true;
            pictureBox1.Visible = true;
            v_Pochette_Ombre.Visible = true;

            eng.StopAllSounds();            
            path = chemin;          
            S = eng.Play2D(source, false, false, true);
            length = Convert.ToInt32(S.PlayLength / 1000);
            
            trackBarPlay.Maximum = length;
            labelAprs.Visible = true;
            labelAvt.Visible = true;

            UpdateTags();
            checkBoxPlay.Checked = false;
        }
        
        /// <summary>
        /// Musique Suivante
        /// </summary>
        private void BtnSuiv_Click(object sender, EventArgs e)
        {
            if (index != dataSet1.PistesLecture.Rows.Count - 1) PlayMusic(dataSet1.PistesLecture.Rows[++index][1].ToString());
            else
            {
                index = 0;
                PlayMusic(dataSet1.PistesLecture.Rows[index][1].ToString());
            }
        }
       
        /// <summary>
        /// Musique precedente
        /// </summary>
        private void BtnPrec_Click(object sender, EventArgs e)
        {
            
            if (index != 0) PlayMusic(dataSet1.PistesLecture.Rows[--index][1].ToString());
            else
            {
                index = dataSet1.PistesLecture.Rows.Count - 1;
                PlayMusic(dataSet1.PistesLecture.Rows[index][1].ToString());
            }
            
        }
       
        /// <summary>
        /// Verifie que l'on est bien en train d'essayer de rajouter une musique
        /// </summary>
        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] Drags = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string Drag in Drags)
                {
                    if (Path.GetExtension(Drag) == ".mp3")
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
        /// Ajout de pistes par DragDrop
        /// </summary>
        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] filepath = (String[])e.Data.GetData(DataFormats.FileDrop);
            XDocument xmlDoc = XDocument.Load("iTunes_Library.xml");
            foreach (string chemin in filepath)
            {
                XML_AjoutPiste(chemin, xmlDoc);
            }
            xmlDoc.Save("iTunes_Library.xml");
            UpdateAlbumList();
        }
       
        /// <summary>
        /// Recherche
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];

            currencyManager1.SuspendBinding();
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
               
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()) || dataGridView1.Rows[i].Cells[1].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()) || dataGridView1.Rows[i].Cells[2].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                    { dataGridView1.Rows[i].Visible = true; }
                    else { dataGridView1.Rows[i].Visible = false; }
                }
            }
            else {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }
            currencyManager1.ResumeBinding();
        }



        /// <summary>
        /// Tous les noms uniques d'albums presents dans notre dataset, utile pour l'affichage par album
        /// </summary>
        private void UpdateAlbumList()
        {
           TableAlbums.Clear();
           TableAlbums = dataSet1.Pistes.DefaultView.ToTable(true, "Album");
            
           trackBarAlbums.Maximum = TableAlbums.Rows.Count-1;
           TableAlbums.DefaultView.Sort = "Album";
            
           if (TableAlbums.Rows.Count <= 1) { trackBarAlbums.Minimum = 0; trackBarAlbums.Value = trackBarAlbums.Maximum; trackBarAlbums.Enabled = false; }
           else {trackBarAlbums.Enabled=true;}
        }
       
        /// <summary>
        /// Met a jours les tags affiches lors de la lecture
        /// </summary>
        private void UpdateTags()
        {
            if (!string.IsNullOrEmpty(path))
            {
                TagLib.File id = TagLib.File.Create(path);
                if (!string.IsNullOrEmpty(id.Tag.Title))
                    v_lbl_Titre.Text = id.Tag.Title;
                else
                    v_lbl_Titre.Text = Path.GetFileNameWithoutExtension(path);
                v_lbl_ArtisteEtAlbum.Text = id.Tag.JoinedPerformers + " - " + id.Tag.Album;
                if (id.Tag.Pictures.Length >= 1)
                {
                    var bin = (byte[])(id.Tag.Pictures[0].Data.Data);
                    pictureBox1.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(55, 55, null, IntPtr.Zero);
                }
                else pictureBox1.Image = null;
            }
            UpdateAlbumList();
            
        }
       
        /// <summary>
        /// Utilisee pour parcourir les albums
        /// </summary>
        private void trackBarAlbums_Scroll(object sender, EventArgs e)
        {
            if (TableAlbums.Rows.Count == 0) { trackBarAlbums.Enabled = false; }
            else trackBarAlbums.Enabled = true;         
            AlbumsNavigate();
        }
       
        /// <summary>
        /// Met a jours l'image affichee lorsque l'on parcours nos albums
        /// </summary>
        private void updateAlbumPicture()
        { 
        TagLib.File id = TagLib.File.Create(dataGridView2.Rows[0].Cells[6].Value.ToString());
            if (id.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(id.Tag.Pictures[0].Data.Data);
                pictureBox3.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(163, 163, null, IntPtr.Zero);
            }
            else pictureBox3.Image = null;
            LabelAlbum.Text ="Album: " + dataGridView2.Rows[0].Cells[2].Value.ToString();
            if (dataGridView2.Rows[0].Cells[2].Value.Equals("Album Inconnu")) { LabelArtiste.Text = "Artiste: Artistes Multiples"; }
            else LabelArtiste.Text = "Artiste: " + dataGridView2.Rows[0].Cells[1].Value;
        }
        
        /// <summary>
        /// Mise a jours des tags sur l'AlbumView
        /// </summary>
        private void AlbumsNavigate()
        {
            if (trackBarAlbums.Value == -1) { trackBarAlbums.Value = 0; }
            string ALBUM = TableAlbums.Rows[trackBarAlbums.Value]["Album"].ToString();
            if (ALBUM.Contains("'")) { ALBUM = ALBUM.Replace("'", ""); }
            pistesBindingSource1.Filter = "Album='" + ALBUM + "'";  //Filtre grace au nom de l'album           
            updateAlbumPicture();
        }
       
        /// <summary>
        /// Met en memoire le datagrid a l'ecran pour l'utiliser lors de la lecture
        /// </summary>
        private void UpdatePistesLecture(DataGridView DgView)
        {
            int i=0;
            dataSet1.PistesLecture.Clear();
            for (i = 0; i < DgView.Rows.Count; i++) 
            {
                if (DgView.Rows[i].Visible == true) 
                {
                    DataRow NewRow = dataSet1.Tables["PistesLecture"].NewRow();
                    NewRow["Checksum"] = DgView.Rows[i].Cells[7].Value.ToString();
                    NewRow["Chemin"] = DgView.Rows[i].Cells[6].Value.ToString();
                    dataSet1.Tables["PistesLecture"].Rows.Add(NewRow);
                
                }
            }
            
        }


        /// <summary>
        /// Supprimer piste en memoire (sinon celle-ci risque d'etre jouee alors qu'elle aura ete effacee)
        /// </summary>
        private void DeletePistesLectures(string ChkSm)
        {
            int i;
            for (i = 0; i < dataSet1.PistesLecture.Rows.Count; i++) 
            {
                if (dataSet1.PistesLecture.Rows[i]["Checksum"].Equals(ChkSm)) { dataSet1.PistesLecture.Rows[i].Delete(); }
            }            
        }
       
        /// <summary>
        /// Jouer de la musique
        /// </summary>
        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PlayMusic(dataGridView2.SelectedRows[0].Cells[6].Value.ToString());
            UpdatePistesLecture(dataGridView2);
            index = dataGridView2.SelectedRows[0].Index;
        }
       
        /// <summary>
        /// Ouvre le browser
        /// </summary>
        private void OpenBrowserButton_Click(object sender, EventArgs e)
        {
            BrowserForm Browser1 = new BrowserForm();
            Browser1.ShowDialog();
        }
      
        /// <summary>
        /// Suppression multiple 
        /// </summary>
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete){
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    DeletePistesLectures(row.Cells[7].Value.ToString());
                    XML_SupprimerPiste(row.Cells[8].Value.ToString()); //Suppression dans le XML
                            dataGridView1.Rows.RemoveAt(row.Index); // Suppression dans la GridView
                            
                }
                
                }
                UpdateAlbumList();
            }
        }
        
        

        /// <summary>
        /// On verifie que le fichier soit bien une image
        /// </summary>
        private void panel2_DragEnter(object sender, DragEventArgs e)
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
        /// Modification d'image d'un Album
        /// </summary>
        private void panel2_DragDrop(object sender, DragEventArgs e)
        {int i;
        for (i = 0; i < dataGridView2.Rows.Count; i++)//Remplace l'AlbumArt de toutes les pistes de l'album
        {
            System.IO.FileInfo PisteEditer = new System.IO.FileInfo(dataGridView2.Rows[i].Cells[6].Value.ToString());//Verifie que le fichier n'est pas en ReadOnly
            if (PisteEditer.IsReadOnly) { MessageBox.Show("Fichier en ReadOnly, aucune edition possible"); }
            else
            {
                TagLib.File id = TagLib.File.Create(dataGridView2.Rows[i].Cells[6].Value.ToString());
                string[] Imageloc = (String[])e.Data.GetData(DataFormats.FileDrop);
                TagLib.Id3v2.AttachedPictureFrame image = new TagLib.Id3v2.AttachedPictureFrame();
                image.Data = TagLib.ByteVector.FromPath(Imageloc[0]);

                id.Tag.Pictures = new TagLib.IPicture[1] { image };
                id.Save();
                pictureBox3.ImageLocation = Imageloc[0];
                Form1.changement = true;
            }
        }
            }

        /// <summary>
        /// Fermeture de l'application
        /// </summary>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}