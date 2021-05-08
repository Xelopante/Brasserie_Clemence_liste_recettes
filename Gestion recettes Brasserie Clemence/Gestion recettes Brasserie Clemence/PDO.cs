using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_recettes_Brasserie_Clemence
{
    public class PDO
    {
        private MySqlConnection laCo;

        public PDO()
        {
            //On instancie la connexion avec la base, l'hôte, le nom d'utilisateur et le mot de passe.
            laCo = new MySqlConnection("database=brasserieclemence; server=127.0.0.1; user id=root; pwd=");
        }

        public int connexionBDD(string login, string mdp)
        {
            //Fait un select count avec le login et le mdp, si il correspond il renverra 1, sinon 0.
            this.laCo.Open();

            string command = "SELECT COUNT(*) FROM user WHERE userLogin='" + login + "' AND userPassword='" + mdp + "';";
            MySqlCommand resultat = new MySqlCommand(command, this.laCo);
            MySqlDataReader rdr = resultat.ExecuteReader();
            rdr.Read();

            int leRes = Convert.ToInt32(rdr[0].ToString());

            rdr.Close();
            this.laCo.Close();

            return leRes;

        }

        public List<Composer> loadComposerRecette(int id)
        {
            //Charge la liste de compositions correpondant à chaque recettes en fonction de leur Id.
            List<Composer> lesCompo = new List<Composer>();

            this.laCo.Open();

            string command = "SELECT * FROM composer WHERE idRecette = " + id + ";";
            MySqlCommand resultat = new MySqlCommand(command, this.laCo);
            MySqlDataReader reader = resultat.ExecuteReader();

            while (reader.Read())
            {
                Composer laCompo = new Composer();

                laCompo.IdIngredient = Convert.ToInt32(reader[0].ToString());
                laCompo.Quantite = Convert.ToDouble(reader[2].ToString());

                lesCompo.Add(laCompo);
            }

            reader.Close();
            this.laCo.Close();

            return lesCompo;
        }

        public List<Recette> loadRecettes()
        {
            //Charge toutes les recettes et en renvoie une liste.
            List<Recette> lesRecettes = new List<Recette>();

            this.laCo.Open();

            string command = "SELECT * FROM recette;";
            MySqlCommand resultat = new MySqlCommand(command, this.laCo);
            MySqlDataReader reader = resultat.ExecuteReader();

            while (reader.Read())
            {
                Recette laRecette = new Recette();

                laRecette.Id = Convert.ToInt32(reader[0].ToString());
                laRecette.Nom = reader[1].ToString();

                string onlydate = reader[2].ToString();
                onlydate = onlydate.Split(' ')[0];
                string j = onlydate.Split('/')[0];
                string m = onlydate.Split('/')[1];
                string a = onlydate.Split('/')[2];
                string ladate = a + "-" + m + "-" + j;

                laRecette.Date = ladate;

                lesRecettes.Add(laRecette);
            }

            reader.Close();
            this.laCo.Close();

            foreach(Recette r in lesRecettes)
            {
                r.LesCompo = loadComposerRecette(r.Id);
            }

            return lesRecettes;
        }

        public List<Ingredient> loadIngredients()
        {
            //Charge tout les ingrédients et en renvoie une liste.
            List<Ingredient> lesIngredients = new List<Ingredient>();

            this.laCo.Open();

            string command = "SELECT * FROM ingredient;";
            MySqlCommand resultat = new MySqlCommand(command, this.laCo);
            MySqlDataReader reader = resultat.ExecuteReader();

            while (reader.Read())
            {
                Ingredient lIngredient = new Ingredient();

                lIngredient.Id = Convert.ToInt32(reader[0].ToString());
                lIngredient.Nom = reader[1].ToString();
                lIngredient.Fournisseur = reader[2].ToString();

                if(reader[3].ToString() != "")
                {
                    lIngredient.NumeroBIO = Convert.ToInt32(reader[3].ToString());
                }
                
                lesIngredients.Add(lIngredient);
            }

            reader.Close();
            this.laCo.Close();

            return lesIngredients;
        }

        public List<Composer> loadComposer()
        {
            //Charge toutes les compositions et en renvoie une liste.
            List<Composer> lesComposers = new List<Composer>();

            this.laCo.Open();

            string command = "SELECT * FROM composer;";
            MySqlCommand resultat = new MySqlCommand(command, this.laCo);
            MySqlDataReader reader = resultat.ExecuteReader();

            while (reader.Read())
            {
                Composer leComposer = new Composer();

                leComposer.IdIngredient = Convert.ToInt32(reader[0].ToString());
                leComposer.Quantite = Convert.ToDouble(reader[2].ToString());

                lesComposers.Add(leComposer);
            }

            reader.Close();
            this.laCo.Close();

            return lesComposers;
        }

        public void supprimerRecette(Recette r)
        {
            //Supprime une recette en supprimant d'abord les compositions auxquelles elle est associée.
            this.laCo.Open();

            string suppression1 = "DELETE FROM composer WHERE idRecette = "+r.Id+";";
            string suppression2 = "DELETE FROM recette WHERE idRecette = " + r.Id + ";";

            MySqlCommand exec1 = new MySqlCommand(suppression1, this.laCo);
            MySqlCommand exec2 = new MySqlCommand(suppression2, this.laCo);

            exec1.ExecuteNonQuery();
            exec2.ExecuteNonQuery();

            this.laCo.Close();
        }

        public void ajouterIngredient(Ingredient i)
        {
            //Insert un ingrédient dans la base et en fonction de l'objet en paramètre, défini si il a un numéro BIO ou non.
            this.laCo.Open();

            string insert = "";

            if(i.NumeroBIO != 0)
            {
                insert = "INSERT INTO ingredient (nomIngredient, fournisseurIngredient, numeroBioIngredient) VALUES ('" + i.Nom + "', '" + i.Fournisseur + "', " + i.NumeroBIO + ");";
            }
            else
            {
                insert = "INSERT INTO ingredient (nomIngredient, fournisseurIngredient) VALUES ('" + i.Nom + "', '" + i.Fournisseur + "');";
            }

            MySqlCommand commande = new MySqlCommand(insert, this.laCo);
            commande.ExecuteNonQuery();

            this.laCo.Close();
        }

        public void supprimerIngredient(Ingredient i)
        {
            //Supprime un ingrédient de la base.
            this.laCo.Open();

            string supprimer = "DELETE FROM ingredient WHERE nomIngredient = '" + i.Nom + "';";

            MySqlCommand commande = new MySqlCommand(supprimer, this.laCo);
            commande.ExecuteNonQuery();

            this.laCo.Close();
        }

        public void modifierIngredient(Ingredient i)
        {
            //Modifie un ingrédient de la base et ajoute ou retire son numéro BIO en fonction de l'objet passé en paramètre.
            this.laCo.Open();

            string commande = "";

            if (i.NumeroBIO != 0)
            {
                commande = "UPDATE ingredient SET nomIngredient='" + i.Nom + "', fournisseurIngredient='" + i.Fournisseur + "', numeroBioIngredient=" + i.NumeroBIO + " WHERE idIngredient=" + i.Id + ";";
            }
            else
            {
                commande = "UPDATE ingredient SET nomIngredient='" + i.Nom + "', fournisseurIngredient='" + i.Fournisseur + "' WHERE idIngredient=" + i.Id + ";";
            }

            MySqlCommand exec = new MySqlCommand(commande, this.laCo);
            exec.ExecuteNonQuery();

            this.laCo.Close();
        }

        public void modifierRecette(Recette r)
        {
            //Modifie une recette dans la base.
            this.laCo.Open();

            string requete = "UPDATE recette SET nomRecette='" + r.Nom + "', dateCreationRecette='" + r.Date + "' WHERE idRecette=" + r.Id + ";";

            MySqlCommand commande = new MySqlCommand(requete, this.laCo);
            commande.ExecuteNonQuery();

            this.laCo.Close();
        }

        public void ajouterRecette(Recette laRecette)
        {
            //Ajoute une recette dans la base.
            this.laCo.Open();

            string requete = "INSERT INTO recette (nomRecette, dateCreationRecette) VALUES ('"+laRecette.Nom+"', '"+laRecette.Date+"');";

            MySqlCommand commande = new MySqlCommand(requete, this.laCo);
            commande.ExecuteNonQuery();

            this.laCo.Close();
        }

        public Recette chargerRecette(Recette laRecette)
        {
            //Charge une recette en fonction de l'objet passé en paramètre.
            Recette retournerRecette = new Recette();

            this.laCo.Open();

            string requete = "SELECT * FROM recette WHERE nomRecette = '" + laRecette.Nom + "';";

            MySqlCommand resultat = new MySqlCommand(requete, this.laCo);
            MySqlDataReader reader = resultat.ExecuteReader();

            while (reader.Read())
            {
                retournerRecette.Id = Convert.ToInt32(reader[0].ToString());
                retournerRecette.Nom = reader[1].ToString();

                string onlydate = reader[2].ToString();
                onlydate = onlydate.Split(' ')[0];
                string j = onlydate.Split('/')[0];
                string m = onlydate.Split('/')[1];
                string a = onlydate.Split('/')[2];
                string ladate = a + "-" + m + "-" + j;

                retournerRecette.Date = ladate;
            }

            reader.Close();
            this.laCo.Close();

            return retournerRecette;
        }

        public void ajouterCompo(Recette laRecette, List<Composer> lesCompos)
        {
            //Crée une composition en fcontion de la recette choisit, son ingrédient et sa quantité.
            this.laCo.Open();

            //Boucle et crée une compo pour chaque objet Composer dans la liste passée en paramètre avec le même id de la recette choisie.
            foreach(Composer c in lesCompos)
            {
                string requete = "INSERT INTO composer (idRecette, idIngredient, quantite) VALUES (" + laRecette.Id + ", " + c.IdIngredient + ", " + c.Quantite.ToString().Replace(',', '.')+ ");";


                MySqlCommand commande = new MySqlCommand(requete, this.laCo);
                commande.ExecuteNonQuery();
            }

            this.laCo.Close();
        }

        public bool etreBIO(Recette r)
        {
            //Vérifie si une recette entière est BIO, on vérifie son nombre d'ingrédients et son nombre d'ingrédients BIO. Si il y a autant d'ingrédients que d'ingrédients BIO, alors la recette entière est BIO.
            this.laCo.Open();

            string requete = "SELECT COUNT(*) FROM composer WHERE idRecette = "+r.Id+";";
            string requete2 = "SELECT COUNT(*) FROM ingredient INNER JOIN composer ON composer.idIngredient = ingredient.idIngredient WHERE idRecette = " + r.Id + " AND numeroBioIngredient IS NOT NULL;";

            MySqlCommand command = new MySqlCommand(requete, this.laCo);
            MySqlCommand command2 = new MySqlCommand(requete2, this.laCo);

            int nbIngredient = 0;
            int nbIngredientBIO = 0;
                
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                nbIngredient = Convert.ToInt32(reader[0].ToString());
            }

            reader.Close();

            MySqlDataReader reader2 = command2.ExecuteReader();
            while(reader2.Read())
            {
                nbIngredientBIO = Convert.ToInt32(reader2[0].ToString());
            }

            reader2.Close();
            this.laCo.Close();

            if(nbIngredient == nbIngredientBIO)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
