using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_recettes_Brasserie_Clemence
{
    public class Composer
    {
        private int idIngredient;
        private double quantite;

        public Composer()
        {
            this.idIngredient = 0;
            this.quantite = 0;
        }

        public Composer(int lId, double laQuantite)
        {
            this.idIngredient = lId;
            this.quantite = laQuantite;
        }

        public int IdIngredient { get => idIngredient; set => idIngredient = value; }
        public double Quantite { get => quantite; set => quantite = value; }
    }
}
