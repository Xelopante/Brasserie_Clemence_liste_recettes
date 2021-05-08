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
    public partial class Consulter : Form
    {
        public Consulter()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Retourne au catalogue.
            Form.ActiveForm.Close();
            Catalogue c = new Catalogue();
            c.Show();
        }

        private void Consulter_Load(object sender, EventArgs e)
        {
            labelRecette.Text = Catalogue.recetteAConsulter.Nom;

            chargerConsultation();
        }

        private void chargerConsultation()
        {
            //Charge la recette, ses ingrédient et leurs quantité en fonction de la liste de compositions de la recette.
            foreach(Composer c in Catalogue.recetteAConsulter.LesCompo)
            {
                listeQuantite.Items.Add(c.Quantite);

                foreach(Ingredient i in Catalogue.lesIngredients)
                {
                    if(i.Id == c.IdIngredient)
                    {
                        listeIngredients.Items.Add(i.Nom);
                    }
                }
            }
        }

        private void chargerConsultationCalcul(double quant)
        {
            //Permet de calculer la quantité voulue en fonction des quantités initiales.
            listeQuantite.Items.Clear();

            foreach (Composer c in Catalogue.recetteAConsulter.LesCompo)
            {
                listeQuantite.Items.Add(c.Quantite * quant);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Appel de la fonction de calcul de quantités.
            chargerConsultationCalcul(Convert.ToDouble(textQuant.Text));
        }
    }
}
