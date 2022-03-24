using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.model
{
    internal class Entree
    {
        public int EntreePK { get; set; }

        public Article articleEntree { get; set; }
        public DateTime entreDate { get; set; }
        public int quantity { get; set; }

        public float prixUnitaire { get; set; }
    }
}
