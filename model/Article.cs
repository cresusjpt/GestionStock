using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.model
{
    internal class Article
    {
        //select * from articles sqldatareader
        public int ArticlePK { get; }
        public string ArticleNom; //{ get; set; }

        public Fournisseur fournisseur
            { get; set; }

        public Categorie categorie { get; set; }

        public string dateExp { get; set; }

        public DateTime dateFab { get; set; }

        public int seuil { get; set; }

        public int prixUnitaireAchat { get; set; }

        public int prixUnitaireVente{ get; set; }

    }
}
