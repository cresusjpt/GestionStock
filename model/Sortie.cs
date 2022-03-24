using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.model
{
    internal class Sortie
    {
        public string Id { get; set; }
        public Article articleSortie { get; set; }

        public DateTime sortieDate { get; set; }

        public int quantity { get; set; }


    }
}
