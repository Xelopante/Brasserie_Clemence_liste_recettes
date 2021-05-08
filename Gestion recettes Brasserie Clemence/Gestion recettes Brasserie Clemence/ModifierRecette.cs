using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_recettes_Brasserie_Clemence
{
    public partial class ModifierRecette : Form
    {
        public ModifierRecette()
        {
            InitializeComponent();
        }

        private void ModifierRecette_Load(object sender, EventArgs e)
        {
            //Affiche le nom et la date de la recette à modifier.
            textNom.Text = Catalogue.recetteAModifier.Nom;
            textDate.Text = Catalogue.recetteAModifier.Date;
        }

        private void BoutonRetour_Click(object sender, EventArgs e)
        {
            //Retour au catalogue.
            Form.ActiveForm.Close();
            Catalogue c = new Catalogue();
            c.Show();
        }

        private void BoutonValider_Click(object sender, EventArgs e)
        {
            //Appel de la fonction de modification depuis PDO.
            Recette r = new Recette();

            r.Nom = textNom.Text;
            r.Date = textDate.Text;
            r.Id = Catalogue.recetteAModifier.Id;

            Catalogue.laPDO.modifierRecette(r);

            MessageBox.Show("Recette modifiée");

            Form.ActiveForm.Close();
            Catalogue c = new Catalogue();
            c.Show();
        }
    }
}
