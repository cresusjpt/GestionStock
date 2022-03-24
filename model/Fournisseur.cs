using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.model.repoinstance;
using System.Data.SqlClient;

namespace GestionStock.model
{
	public class Fournisseur
	{

		public int reference { get; set; }

		public string nomF { get; set; }

		public string contact { get; set; }

		public string contactTitre {get; set;}

		public string adresse { get; set; }

		public string ville { get; set; }

		public int codePostal { get; set; }

		public int department { get; set; }

		public string country { get; set; }

		public string numTel { get; set; }

		public string condPaiement { get; set; }

		public string email	{ get; set; }

		public string observation { get; set; }

		//la méthode ExecutenonQuery de la classe SqlCommand renvoie le nombre d'enrégistrement affectés par la requête
		//alors que Executereader renvoie une collection des enrégistrement répondant à la condition de la requête

		public int size()
        {
			string query = "SELECT COUNT(*) FROM Fournisseurs";

			return DatabaseContext.exec(query);
        }


		public Fournisseur insert()
        {
			string requete = "INSERT INTO Fournisseurs (NomFournisseur, NomContact, TitreContact, Adresse, Ville, CodePostal, DepartementOuRegion, Pays, NumeroTel, ConditionsPaiements, AdresseEmail, Remarques) " +
                "VALUES("+ this.nomF+", "+ this.contact+ ", " + this.contactTitre + ", " + this.adresse + ", " + this.ville + ", " + this.codePostal + ", " + this.department + ", " + this.country + ", " + this.numTel + ", " + this.condPaiement + ", " + this.observation + ");";

			DatabaseContext.exec(requete);

			return this;
        }

		//modifier le fournisseur envoyé en paramètre
		public Fournisseur edit(Fournisseur fournisseur)
        {
			string query = "UPDATE Fournisseurs SET NomFournisseur= "+fournisseur.nomF+ " ,NomContact=" + fournisseur.contact + " ,TitreContact=" + fournisseur.contactTitre + ",Adresse=" + fournisseur.adresse + ",Ville=" + fournisseur.ville + ",CodePostal=" + fournisseur.codePostal + ",DepartementOuRegion=" + fournisseur.department + ",Pays=" + fournisseur.country + ",NumeroTel=" + fournisseur.numTel + ",ConditionsPaiements=" + fournisseur.condPaiement + ",AdresseEmail=" + fournisseur.email + ",Remarques=" + fournisseur.observation + " WHERE RefFournisseur=" + fournisseur.reference + "";

			DatabaseContext.exec(query);

			return fournisseur;
		}

		//supprimer le fournisseur avec la référence envoyé en paramètre de la méthode
		public int delete(int id)
        {
			string query = "delete from Fournisseurs where RefFournisseur=" + id + "";

			return DatabaseContext.exec(query);
		}


		public Fournisseur showById(int reference)
        {
			Fournisseur fournisseur = new Fournisseur();

			string query = "SELECT * from Fournisseurs where RefFournisseur=" + reference + "";

			SqlDataReader resultat =  DatabaseContext.execWithresult(query);

            if (resultat.HasRows )
            {
				fournisseur.reference = (int)resultat["RefFournisseur"];
				fournisseur.nomF = (string) resultat["NomFournisseur"];
				fournisseur.contact = (string) resultat["NomContact"];
				fournisseur.contactTitre = (string) resultat["TitreContact"];
				fournisseur.adresse = (string) resultat["Adresse"];
				fournisseur.ville = (string) resultat["Ville"];
				fournisseur.codePostal = (int) resultat["CodePostal"];
				fournisseur.department = (int) resultat["DepartementOuRegion"];
				fournisseur.country = (string) resultat["Pays"];
				fournisseur.numTel = (string) resultat["NumeroTel"];
				fournisseur.condPaiement = (string) resultat["ConditionsPaiements"];
				fournisseur.email = (string) resultat["AdresseEmail"];
				fournisseur.observation = (string) resultat["Remarques"];
				
				/*fournisseur.reference = resultat.GetInt32(0);
				fournisseur.nomF =  resultat.GetString(1);
				fournisseur.contact = resultat.GetString(2);
				fournisseur.contactTitre = resultat.GetString(3);
				fournisseur.adresse = resultat.GetString(4);
				fournisseur.codePostal = resultat.GetInt32(5);
				fournisseur.department = resultat.GetInt32(6);
				fournisseur.country = resultat.GetString(7);
				fournisseur.numTel = resultat.GetString(8);
				fournisseur.condPaiement = resultat.GetString(9);
				fournisseur.email = resultat.GetString(10);
				fournisseur.observation = resultat.GetString(11);*/

			}

			return fournisseur;
		}

		public List<Fournisseur> showAll()
        {
			List<Fournisseur> list = new List<Fournisseur>();
			string query = "SELECT * FROM Fournisseurs";
			SqlDataReader resultat = DatabaseContext.execWithresult(query);

			if (resultat.HasRows)
			{
                while (resultat.Read())
                {
					Fournisseur fournisseur = new Fournisseur();

					fournisseur.reference = (int)resultat["RefFournisseur"];
					fournisseur.nomF = (string)resultat["NomFournisseur"];
					fournisseur.contact = (string)resultat["NomContact"];
					fournisseur.contactTitre = (string)resultat["TitreContact"];
					fournisseur.adresse = (string)resultat["Adresse"];
					fournisseur.ville = (string)resultat["Ville"];
					fournisseur.codePostal = (int)resultat["CodePostal"];
					fournisseur.department = (int)resultat["DepartementOuRegion"];
					fournisseur.country = (string)resultat["Pays"];
					fournisseur.numTel = (string)resultat["NumeroTel"];
					fournisseur.condPaiement = (string)resultat["ConditionsPaiements"];
					fournisseur.email = (string)resultat["AdresseEmail"];
					fournisseur.observation = (string)resultat["Remarques"];

					list.Add(fournisseur);
				}
			}
				return list;
		}
    }
}
