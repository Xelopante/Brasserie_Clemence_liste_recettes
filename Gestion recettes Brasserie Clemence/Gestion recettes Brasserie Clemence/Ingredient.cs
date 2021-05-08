using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_recettes_Brasserie_Clemence
{
    public class Ingredient
    {
        private int id;
        private string nom;
        private string fournisseur;
        private int numeroBIO;

        public Ingredient()
        {
            this.id = 0;
            this.nom = "un nom";
            this.fournisseur = "Marex";
            this.numeroBIO = 0;
        }

        public Ingredient(int lId, string leNom, string leFournisseur, int leNumBio)
        {
            this.id = lId;
            this.nom = leNom;
            this.fournisseur = leFournisseur;
            this.numeroBIO = leNumBio;
        }

        public Ingredient(int lId, string leNom, string leFournisseur)
        {
            this.id = lId;
            this.nom = leNom;
            this.fournisseur = leFournisseur;
            this.numeroBIO = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Fournisseur { get => fournisseur; set => fournisseur = value; }
        public int NumeroBIO { get => numeroBIO; set => numeroBIO = value; }
    }
}
