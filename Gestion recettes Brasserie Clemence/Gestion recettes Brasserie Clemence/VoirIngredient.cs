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
    public partial class VoirIngredient : Form
    {
        public static Ingredient ingredientAModifier;

        public VoirIngredient()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Choisit l'ingrédient à modifier pour la Form de modification.
            if(listeIngredient.SelectedItem != null)
            {
                foreach (Ingredient i in Catalogue.lesIngredients)
                {
                    if (i.Nom == listeIngredient.SelectedItem.ToString())
                    {
                        ingredientAModifier = i;
                    }
                }

                Form.ActiveForm.Close();
                ModifierIngredient m = new ModifierIngredient();
                m.Show();
            }
        }

        private void BoutonSupprimer_Click(object sender, EventArgs e)
        {
            //Supprime l'ingrédient choisi dans la listBox avec une fonction de PDO.
            if (listeIngredient.SelectedItem != null)
            {
                Ingredient i = new Ingredient();

                i.Nom = listeIngredient.SelectedItem.ToString();

                Catalogue.laPDO.supprimerIngredient(i);

                MessageBox.Show("Ingrédient supprimé");

                Form.ActiveForm.Close();
                Catalogue c = new Catalogue();
                c.Show();
            }   
        }

        private void BoutonRetour_Click(object sender, EventArgs e)
        {
            //Retour au catalogue.
            Form.ActiveForm.Close();
            Catalogue c = new Catalogue();
            c.Show();
        }

        private void VoirIngredient_Load(object sender, EventArgs e)
        {
            foreach(Ingredient i in Catalogue.lesIngredients)
            {
                listeIngredient.Items.Add(i.Nom);
            }
        }
    }
}
