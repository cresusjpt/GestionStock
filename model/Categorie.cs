using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.model
{
    internal class Categorie
    {
        public int reference { get; set; }
        public string nom { get; set; }
        public AnneeExercice anneExercice { get; set; }
    }
}
