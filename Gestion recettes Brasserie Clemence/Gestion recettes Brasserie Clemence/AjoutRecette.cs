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
    public partial class AjoutRecette : Form
    {
        public AjoutRecette()
        {
            InitializeComponent();
        }

        private void BoutonRetour_Click(object sender, EventArgs e)
        {
            //Retour au catalogue.
            Form.ActiveForm.Close();
            Catalogue c = new Catalogue();
            c.Show();
        }

        private void AjoutRecette_Load(object sender, EventArgs e)
        {
            //Charge tout les ingrédients existants dans la comboBox.
            foreach(Ingredient i in Catalogue.lesIngredients)
            {
                comboIngredient.Items.Add(i.Nom);
            }
        }

        private void BoutonIngredient_Click(object sender, EventArgs e)
        {
            //Ajoute l'ingrédient choisi et sa quantité dans la listBox.
            if(comboIngredient.SelectedItem != null && textQuantiteIngredient.Text != "")
            {
                string nomIngre = comboIngredient.SelectedItem.ToString();
                double quantiteIngre = Convert.ToDouble(textQuantiteIngredient.Text);

                listeIngredient.Items.Add(nomIngre + " | " + quantiteIngre);
            }
        }

        private void BoutonSupprimer_Click(object sender, EventArgs e)
        {
            //Supprime l'ingrédient choisi de la listBox.
            if(listeIngredient.SelectedItem != null)
            {
                int pos = Convert.ToInt32(listeIngredient.SelectedIndex.ToString());
                listeIngredient.Items.RemoveAt(pos);
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Ajoute la recette et ses ingrédients avec les fonctions d'ajout PDO.
            if(textNomRecette.Text != "" && textDateRecette.Text != "" && listeIngredient.Items != null)
            {
                List<Composer> lesCompo = new List<Composer>();

                //On crée une recette avec son nom et sa date, puis on la reprend afin d'obtenir son id.
                Recette laRecette = new Recette();
                Recette laRecette2 = new Recette();

                laRecette.Nom = textNomRecette.Text;
                laRecette.Date = textDateRecette.Text;

                Catalogue.laPDO.ajouterRecette(laRecette);

                laRecette2 = Catalogue.laPDO.chargerRecette(laRecette);

                //On crée la composition avec les ingrédients et les quantités de la listBox séparés par un Split, puis on ajoute les compo dans une liste.
                foreach (object item in listeIngredient.Items)
                {
                    string[] splitIngredient = item.ToString().Split('|');
                    string nomIngredient = splitIngredient[0].Trim(' ');
                    double quantiteIngredient = Convert.ToDouble(splitIngredient[1].Trim(' '));

                    Ingredient lIngredient = new Ingredient();

                    foreach (Ingredient i in Catalogue.lesIngredients)
                    {
                        if (i.Nom == nomIngredient)
                        {
                            lIngredient = i;
                        }
                    }

                    Composer laCompo = new Composer();

                    if (lIngredient.Id != 0)
                    {
                        laCompo.IdIngredient = lIngredient.Id;
                        laCompo.Quantite = quantiteIngredient;

                        lesCompo.Add(laCompo);
                    }
                }

                Catalogue.laPDO.ajouterCompo(laRecette2, lesCompo);

                Form.ActiveForm.Close();
                Catalogue c = new Catalogue();
                c.Show();
            }
            else
            {
                MessageBox.Show("Veuillez renseigner un nom, une date et un ingrédient correcte pour votre recette");
            }
            
        }
    }
}
