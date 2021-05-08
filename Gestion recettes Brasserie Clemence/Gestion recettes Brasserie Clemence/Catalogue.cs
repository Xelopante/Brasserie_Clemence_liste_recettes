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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Gestion_recettes_Brasserie_Clemence
{
    public partial class Catalogue : Form
    {
        //On créé des listes pour les tables de la BDD ainsi que des objets pour passer aux différentes formes.
        public static List<Recette> lesRecettes;
        public static List<Ingredient> lesIngredients;
        public static List<Composer> lesComposers;
        public static PDO laPDO;
        public static Recette recetteAModifier;
        public static Recette recetteAConsulter;

        public Catalogue()
        {
            //On instancie les listes et l'objet PDO pour les requêtes à la BDD.
            InitializeComponent();
            lesRecettes = new List<Recette>();
            lesIngredients = new List<Ingredient>();
            lesComposers = new List<Composer>();
            laPDO = new PDO();
        }

        private void Catalogue_Load(object sender, EventArgs e)
        {
            //On appelle les fonctions de chargement.
            LoadRecettes();
            LoadIngredients();
            LoadComposers();
        }

        private void LoadRecettes()
        {
            //Charge les recettes depuis la classe PDO.
            lesRecettes = laPDO.loadRecettes();

            //Les affiche dans la comboBox de la Form.
            foreach (Recette r in lesRecettes)
            {
                listeRecette.Items.Add(r.Nom);
            }
        }

        private void LoadIngredients()
        {
            //Charge les ingrédients depuis la classe PDO.
            lesIngredients = laPDO.loadIngredients();
        }

        private void LoadComposers()
        {
            //Charge les compositions depuis la classe PDO.
            lesComposers = laPDO.loadComposer();
        }

        private void BoutonDeco_Click(object sender, EventArgs e)
        {
            //Retour à l'écran de connexion.
            Form.ActiveForm.Close();
            Connexion c = new Connexion();
            c.Show();
        }

        private void BoutonAjoutIngredient_Click(object sender, EventArgs e)
        {
            //Charge la Form d'ajout d'ingrédients.
            Form.ActiveForm.Close();
            AjoutIngredient a = new AjoutIngredient();
            a.Show();
        }

        private void BoutonAjoutRecette_Click(object sender, EventArgs e)
        {
            //Charge la Form d'ajout de recettes.
            Form.ActiveForm.Close();
            AjoutRecette a = new AjoutRecette();
            a.Show();
        }

        private void BoutonConsult_Click(object sender, EventArgs e)
        {
            //Charge la Form de consultation de recette.
            if (listeRecette.SelectedItem != null)
            {
                //Vérifie la Recette à utiliser dans la Form.
                foreach (Recette r in lesRecettes)
                {
                    if (listeRecette.SelectedItem.ToString() == r.Nom)
                    {
                        recetteAConsulter = r;
                    }
                }

                Form.ActiveForm.Close();
                Consulter c = new Consulter();
                c.Show();
            }
        }
        private void BoutonModif_Click(object sender, EventArgs e)
        {
            //Charge la Form de modification de recettes.
            if (listeRecette.SelectedItem != null)
            {
                //Vérifie la Recette à utiliser dans la Form.
                foreach (Recette r in lesRecettes)
                {
                    if (listeRecette.SelectedItem.ToString() == r.Nom)
                    {
                        recetteAModifier = r;
                    }
                }

                Form.ActiveForm.Close();
                ModifierRecette m = new ModifierRecette();
                m.Show();
            }
        }

        private void BoutonSupp_Click(object sender, EventArgs e)
        {
            //Supprime la recette choisie.
            if (listeRecette.SelectedItem != null)
            {
                Recette laRecette = new Recette();

                //Vérifie la recette à supprimer.
                foreach (Recette r in lesRecettes)
                {
                    if (r.Nom == listeRecette.SelectedItem.ToString())
                    {
                        laRecette = r;
                    }
                }

                //Appel de la fonction supprimer depuis PDO.
                laPDO.supprimerRecette(laRecette);

                MessageBox.Show("Recette supprimée");

                //Recharge la Form catalogue pour actualiser les listes avec le Form_Load.
                Form.ActiveForm.Close();
                Catalogue c = new Catalogue();
                c.Show();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Charge la Form de visualisation d'ingrédients.
            Form.ActiveForm.Close();
            VoirIngredient v = new VoirIngredient();
            v.Show();
        }

        public void genererPDF()
        {
            //Permet de créer un PDF contenant toutes les recettes avec leurs ingrédients et quantités.

            //Création d'un tableau à 3 colonnes.
            PdfPTable tableau = new PdfPTable(3);

            //Définition de la police des phrases.
            BaseFont Police = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            //Définition de la taille et la forme de la police pour les titres.
            iTextSharp.text.Font TitresFont = new iTextSharp.text.Font(Police, 12, iTextSharp.text.Font.BOLD);

            //Création et ajout des cellules avec les titres et un fond grisé.
            PdfPCell titreRecette = new PdfPCell(new Phrase("Recettes", TitresFont));
            titreRecette.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

            PdfPCell titreIngredient = new PdfPCell(new Phrase("Ingrédients", TitresFont));
            titreIngredient.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

            PdfPCell titreQuantite = new PdfPCell(new Phrase("Quantités (litres, grammes, unité)", TitresFont));
            titreQuantite.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

            tableau.AddCell(titreRecette);
            tableau.AddCell(titreIngredient);
            tableau.AddCell(titreQuantite);

            //Définition de la taille et la forme de la police pour les données.
            iTextSharp.text.Font NormalFont = new iTextSharp.text.Font(Police, 11, iTextSharp.text.Font.NORMAL);

            //Ajoute une cellule pour chaque recette.
            foreach (Recette r in lesRecettes)
            {
                PdfPCell nomRecette = new PdfPCell(new Phrase(r.Nom, NormalFont));
                tableau.AddCell(nomRecette);

                //Permet de garder un décalage tant qu'on est dans la même recette.
                int position = 0;

                //Ajoute une cellule pour chaque ingrédient retrouvé en fonction de la composition.
                foreach (Composer c in r.LesCompo)
                {
                    foreach (Ingredient i in lesIngredients)
                    {
                        if (c.IdIngredient == i.Id)
                        {
                            if (position > 0)
                            {
                                PdfPCell vide = new PdfPCell(new Phrase(" ", NormalFont));
                                tableau.AddCell(vide);
                            }

                            PdfPCell nomIngredient = new PdfPCell(new Phrase(i.Nom + ", " + i.Fournisseur, NormalFont));
                            tableau.AddCell(nomIngredient);

                            PdfPCell quantiteIngredient = new PdfPCell(new Phrase(c.Quantite.ToString(), NormalFont));
                            tableau.AddCell(quantiteIngredient);

                            position++;
                        }
                    }
                }
            }

            //Définit un nom et une extension de base pour le fichier.
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = "test";
            savefiledialog.DefaultExt = ".pdf";

            //Ouvre une fenêtre de dialogue pour l'enregistrement du fichier.
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document PDF = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(PDF, stream);
                    PDF.Open();
                    PDF.Add(tableau);
                    PDF.Close();
                    stream.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Appel de la fonction de génération de PDF.
            genererPDF();
        }

        private void listeRecette_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Vérifie à chaque fois qu'on change de choix dans la comboBox que la recette est bio ou non par l'appel de la fonction depuis PDO.
            if (listeRecette.SelectedItem != null)
            {
                Recette laRecetteBio = new Recette();

                foreach (Recette r in lesRecettes)
                {
                    if (r.Nom == listeRecette.SelectedItem.ToString())
                    {
                        laRecetteBio = r;
                    }
                }

                if (laPDO.etreBIO(laRecetteBio))
                {
                    labelBIO.Visible = true;
                }
                else
                {
                    labelBIO.Visible = false;
                }
            }
        }
    }
}
