using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_recettes_Brasserie_Clemence
{
    public class Recette
    {
        private int id;
        private string nom;
        private string date;
        private List<Composer> lesCompo;

        public Recette()
        {
            this.id = 0;
            this.nom = "la sousoupe";
            this.date = "2001/09/11";
            this.lesCompo = new List<Composer>();
        }

        public Recette(int lId, string leNom, string laDate)
        {
            this.id = lId;
            this.nom = leNom;
            this.date = laDate;
            this.lesCompo = new List<Composer>();
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Date { get => date; set => date = value; }
        public List<Composer> LesCompo { get => lesCompo; set => lesCompo = value; }
    }
}
