using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.model.repoinstance;
using System.Data.SqlClient;

namespace GestionStock.model
{
    internal class AnneeExercice
    {
        public int codeAE { get; set; }

        public String anneeExercice { get; set; }

        public AnneeExercice() { }

        public AnneeExercice(string anneeE)
        {
            this.anneeExercice = anneeE;
        }

        public AnneeExercice insert()
        {
            string query = "INSERT INTO AnneeExercice VALUES ('" + this.anneeExercice + "')";
            DatabaseContext.exec(query);
            return this;
        }

        public AnneeExercice update()
        {
            string query = "UPDATE AnneeExercice SET AnneeExercice= '" + this.anneeExercice + "' where codeAE='" + this.codeAE + "'";

            DatabaseContext.exec(query);
            return this;
        }

        public bool delete(int id)
        {
            string query = "delete from AnneeExercice where CodeAE= '" + id + "'";
            return DatabaseContext.exec(query) == 1;
        }

        public List<AnneeExercice> showAll()
        {
            List<AnneeExercice> list = new List<AnneeExercice>();
            string query = "SELECT * FROM AnneeExercice";

            SqlDataReader resultat = DatabaseContext.execWithresult(query);
            if (resultat.HasRows)
            {
                while (resultat.Read())
                {
                    AnneeExercice ae = new AnneeExercice();
                    ae.codeAE = resultat.GetInt32(0);
                    ae.anneeExercice = resultat.GetDateTime(1).ToString();
                    list.Add(ae);
                }
            }
            DatabaseContext.close();
            return list;
        }

        public AnneeExercice showById(int id)
        {
            AnneeExercice ae = new AnneeExercice();
            string query = "SELECT *  FROM AnneeExercice where CodeAE=" + this.codeAE + "'";
            SqlDataReader resultat = DatabaseContext.execWithresult(query);

            if (resultat.HasRows && resultat.Read())
            {
                ae.codeAE = resultat.GetInt32(0);
                ae.anneeExercice = resultat.GetDateTime(1).ToString();
            }

            return ae;
        }
    }
}
