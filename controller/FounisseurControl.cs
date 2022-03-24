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
        public void show()
        {

        }

        //afficher un enrégistrement 
        public Fournisseur showById(int id)
        {
            return new Fournisseur();
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
