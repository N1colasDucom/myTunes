using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace iTunes
{
    public partial class AjoutMorceauDansPlaylist : Form
    {
        public AjoutMorceauDansPlaylist()
        {
            InitializeComponent();
            XDocument xmlDoc = XDocument.Load("iTunes_Playlists.xml");
            var nomsDesPlaylists = (from elt in xmlDoc.Elements("Playlists").Elements("Playlist") select elt.Attribute("nom").Value);
            foreach (var nom in nomsDesPlaylists) comboBox1.Items.Add(nom);
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            XDocument xmlDoc = XDocument.Load("iTunes_Playlists.xml");
            var nomsDesPlaylists = (from elt in xmlDoc.Elements("Playlists").Elements("Playlist") select elt.Attribute("nom").Value);

            Boolean correspondance = false;           
            foreach (var nom in nomsDesPlaylists) if (comboBox1.Text == nom) correspondance = true;
            if (String.IsNullOrEmpty(comboBox1.Text)) this.Close();
            else if (correspondance == true)
            {
                IEnumerable<XElement> playlistUtilisee = (from nom in xmlDoc.Elements("Playlists").Elements("Playlist") where ((string)nom.Attribute("nom")).Equals(comboBox1.Text) select nom);
                foreach (XElement nom in playlistUtilisee) nom.Add(new XElement("Id_Morceau", Form1.passage_Id));   
                xmlDoc.Save("iTunes_Playlists.xml");
                this.Close();
            }
            else
            {
                xmlDoc.Element("Playlists").Add(
                            new XElement("Playlist",
                                new XAttribute("nom", comboBox1.Text),
                                    new XElement("Id_Morceau", Form1.passage_Id)
                                )
                        );
                xmlDoc.Save("iTunes_Playlists.xml");
                Form1.nvlePlaylistAAfficherDansMenu = true;
                this.Close();
            }
        }
    }
}
