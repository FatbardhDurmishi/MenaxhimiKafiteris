using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MenaxhimiKafiteris.DAL
{
    public class RoletRepository
    {
        public DataSet GetAll()
        {

            try
            {
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DataSet ds = new DataSet();
                    DatabaseConfig.adapter = new SqlDataAdapter();
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrRolet", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
