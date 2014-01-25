using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTunes
{//Lors du lancement du programe, affiche le nom de tous les morceaux qui n'ont pas etes trouves (et qui ne seront donc pas affiches.)
    public partial class MsBoxIntrouvable : Form
    {
        public MsBoxIntrouvable(List<string> _liste)
        {
            InitializeComponent();
            BindingList<string> Musiques = new BindingList<string>(_liste);
            this.comboBox1.DataSource = Musiques;
            
        }

    }
}
