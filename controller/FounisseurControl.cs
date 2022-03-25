using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.model;

namespace GestionStock.controller
{
    internal class FounisseurControl
    {
        //afficher tout les enrégistrements du modèle
<<<<<<< HEAD
        public List<Fournisseur> show()
        {
            return new Fournisseur().showAll();
=======
        public void show()
        {

>>>>>>> 9e1dfd95c19a77a2f2a3df4a328cb94a1b3b6e60
        }

        //afficher un enrégistrement 
        public Fournisseur showById(int id)
        {
<<<<<<< HEAD
            return new Fournisseur().showById(id);
=======
            return new Fournisseur();
>>>>>>> 9e1dfd95c19a77a2f2a3df4a328cb94a1b3b6e60
        }

        public Fournisseur search(string condition)
        {
            return new Fournisseur();
        }

        public Fournisseur add(Fournisseur fournisseur)
        {
            return fournisseur.insert();
        }

        public Fournisseur edit(Fournisseur fournisseur)
        {
            return new Fournisseur();
        }

        public bool delete(Fournisseur fournisseur)
        {
            return false;
        }

    }
}
