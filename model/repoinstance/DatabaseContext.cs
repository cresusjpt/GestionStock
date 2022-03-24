using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionStock.model.repoinstance
{

    //cette classe nous permet de recupérer une instance de la base de données a chaque fois que l'on aura besoin d'utiliser notre base de données on 
    //au lieu de faire des new à chaque fois
    public class DatabaseContext
    {
        public static string connectionString = "Data Source=localhost;Initial Catalog=geststock;Integrated Security=True";
        private static SqlConnection _instance;

        //contructeur privé empêche d'instancier notre class en dehors de ce namespace
        //a la place on va utiliser la méthode getinstance qui s'assurera que l'objet n'existait pas
        private DatabaseContext()
        {
            _instance = new SqlConnection(connectionString);
        }

        public static SqlConnection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SqlConnection(connectionString);
            }
            return _instance;
        }

        public static int exec(string query)
        {
            SqlCommand cmd = new SqlCommand(query,GetInstance());
            _instance.Open();
            int ret = cmd.ExecuteNonQuery();
            _instance.Close();

            return ret;
        }

        public static SqlDataReader execWithresult(string query)
        {
            SqlCommand cmd = new SqlCommand(query, GetInstance());
            _instance.Open();
            SqlDataReader ret = cmd.ExecuteReader();
            _instance.Close();

            return ret;

        }




    }
}
