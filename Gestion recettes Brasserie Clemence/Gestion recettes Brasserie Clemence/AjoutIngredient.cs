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
    public partial class AjoutIngredient : Form
    {
        public AjoutIngredient()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Retour au catalogue.
            Form.ActiveForm.Close();
            Catalogue c = new Catalogue();
            c.Show();
        }

        private void AjoutIngredient_Load(object sender, EventArgs e)
        {

        }

        private void CheckBIO_CheckedChanged(object sender, EventArgs e)
        {
            //Affiche ou non la textBox de numero bio si la checkbox est validée.
            if(checkBIO.Checked)
            {
                labelNumeroBIO.Visible = true;
                textNumeroBIO.Visible = true;
            }

            if(!checkBIO.Checked)
            {
                labelNumeroBIO.Visible = false;
                textNumeroBIO.Visible = false;
            }
        }

        private void BoutonAjouter_Click(object sender, EventArgs e)
        {
            //Appel de la fonction d'ajout d'ingrédients de PDO.
            if(textNomIngredient.Text != "" && textFournisseurIngredient.Text != "")
            {
                Ingredient i = new Ingredient();

                i.Nom = textNomIngredient.Text;
                i.Fournisseur = textFournisseurIngredient.Text;

                if (textNumeroBIO.Text != "")
                {
                    i.NumeroBIO = Convert.ToInt32(textNumeroBIO.Text);
                }

                Catalogue.laPDO.ajouterIngredient(i);

                MessageBox.Show("Ingrédient ajouté");

                Form.ActiveForm.Close();
                Catalogue c = new Catalogue();
                c.Show();
            }
            else
            {
                MessageBox.Show("Veuillez renseigner un nom et/ou un fournisseur correct");
            }
        }
    }
}
