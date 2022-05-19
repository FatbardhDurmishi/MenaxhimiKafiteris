using System.Configuration;
using System.Data.SqlClient;

namespace MenaxhimiKafiteris.DAL
{
    public class DatabaseConfig
    {

        //conStringDorentina ndodhet ne app config of Projekti_TI_1_GR_2

        //ConfigurationManager helps to read the config string from app.config
        //We are here storing only the connectionString

        //ConfigurationManager nuk njifet si klas, e duhet me shtu na the file ne App.Config.
        //We already have the App.Config, and now we just add it as reference to the main sauce
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["conStringBardhi"].ConnectionString;
        //public static string ConnectionString2 = ConfigurationManager.ConnectionStrings[].ConnectionString;

        //In other class we make the connection by passing the string there.
        public static SqlConnection connection;
        public static SqlCommand command;
        public static SqlDataAdapter adapter;
        public static SqlDataReader reader;
    }
}
