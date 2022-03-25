using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.model;

namespace GestionStock.controller
{
    internal class AnneExerciceControl
    {
        private AnneeExercice anneeE;

        public AnneExerciceControl()
        {
            anneeE = new AnneeExercice();
        }

        public AnneeExercice add(AnneeExercice aE)
        {
            return aE.insert();
        }

        public bool delete(int id)
        {
            return anneeE.delete(id);
        }

        public List<AnneeExercice> show()
        {
            return anneeE.showAll();
        }

        public AnneeExercice showOne(int id)
        {
            return anneeE.showById(id);
        }

        public AnneeExercice search(string search)
        {
            return anneeE;
        }
    }
}
