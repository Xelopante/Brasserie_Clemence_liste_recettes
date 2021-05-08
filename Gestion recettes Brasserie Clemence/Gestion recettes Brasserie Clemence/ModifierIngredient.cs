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
    public partial class ModifierIngredient : Form
    {
        public ModifierIngredient()
        {
            InitializeComponent();
        }

        private void ModifierIngredient_Load(object sender, EventArgs e)
        {
            //Charge l'ingrédient choisi dans le catalogue.
            textNomIngredient.Text = VoirIngredient.ingredientAModifier.Nom;
            textFournisseurIngredient.Text = VoirIngredient.ingredientAModifier.Fournisseur;

            //Si il a un numério BIO on affiche la textBox BIO.
            if(VoirIngredient.ingredientAModifier.NumeroBIO != 0)
            {
                checkBIO.Checked = true;
                textNumeroBIO.Text = Convert.ToString(VoirIngredient.ingredientAModifier.NumeroBIO);
            }
        }

        private void BoutonRetour_Click(object sender, EventArgs e)
        {
            //Retour au catalogue.
            Form.ActiveForm.Close();
            Catalogue c = new Catalogue();
            c.Show();
        }

        private void CheckBIO_CheckedChanged(object sender, EventArgs e)
        {
            //Affiche ou non la textBox de numero bio si la checkbox est validée.
            if (checkBIO.Checked)
            {
                labelNumeroBIO.Visible = true;
                textNumeroBIO.Visible = true;
            }

            if (!checkBIO.Checked)
            {
                labelNumeroBIO.Visible = false;
                textNumeroBIO.Visible = false;
            }
        }

        private void BoutonAjouter_Click(object sender, EventArgs e)
        {
            //Récupère les infos des textBox et les insert avec la fonction PDO.
            Ingredient i = new Ingredient();

            i.Id = VoirIngredient.ingredientAModifier.Id;
            i.Nom = textNomIngredient.Text;
            i.Fournisseur = textFournisseurIngredient.Text;
            
            if(checkBIO.Checked)
            {
                i.NumeroBIO = Convert.ToInt32(textNumeroBIO.Text);
            }

            Catalogue.laPDO.modifierIngredient(i);

            MessageBox.Show("Ingrédient modifié");

            Form.ActiveForm.Close();
            Catalogue c = new Catalogue();
            c.Show();
        }
    }
}
