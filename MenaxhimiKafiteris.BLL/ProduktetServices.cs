using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiKafiteris.DAL;
using System.Data;
using System.Data.SqlClient;
using MenaxhimiKafiteris.BO;

namespace MenaxhimiKafiteris.BLL
{
    public class ProduktetServices
    {
        private ProduktetRepository produktetRepository;
        public ProduktetServices()
        {
            produktetRepository = new ProduktetRepository();
        }
        public DataSet GetAll()
        {
            return produktetRepository.GetAll();
        }
        public bool FshiProdukt(int ID)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand(" usp_DeleteProdukt", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@produktID", ID);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool ShtoProdukt(Produkti produkti)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand(" usp_ShtoLlojTeProduktit", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@emri", produkti.Emri);
                    DatabaseConfig.command.Parameters.AddWithValue("@cmimi", produkti.Cmimi);
                    DatabaseConfig.command.Parameters.AddWithValue("@sasia", produkti.Sasia);
                    DatabaseConfig.command.Parameters.AddWithValue("@llojiID", produkti.LlojiID);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }

            // loadData();
        }
    }
    
}
