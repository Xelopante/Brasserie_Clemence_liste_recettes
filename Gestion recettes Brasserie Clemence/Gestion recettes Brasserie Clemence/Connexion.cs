using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_recettes_Brasserie_Clemence
{
    public partial class Connexion : Form
    {
        public PDO lePDO;
        public Connexion()
        {
            //On créé un objet PDO et on l'instancie.
            InitializeComponent();
            lePDO = new PDO();
        }

        private void BoutonConnect_Click(object sender, EventArgs e)
        {
            //Appel de la fonction de connexion.
            ConnexionBDD();
        }

        private void ConnexionBDD()
        {
            //Appel de la fonction de connexion depuis la classe PDO, retourne un entier.
            int laVariable = lePDO.connexionBDD(textLogin.Text, textMdp.Text);

            if (laVariable > 0)
            {
                Catalogue c = new Catalogue();
                c.Show();
                this.Visible = false;
            }
        }

        private void BoutonQuitter_Click(object sender, EventArgs e)
        {
            //Quitte l'application.
            Application.Exit();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
