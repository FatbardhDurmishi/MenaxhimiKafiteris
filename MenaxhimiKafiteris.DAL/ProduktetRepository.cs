using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MenaxhimiKafiteris.BO;

namespace MenaxhimiKafiteris.DAL
{
    public class ProduktetRepository
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
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrProduktet", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int GetLastProdukt()
        {


            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_MerrProduktinFundit", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure with outPut parameter
                    SqlParameter outputSqlParameter = new SqlParameter();
                    outputSqlParameter.ParameterName = "@productID";
                    outputSqlParameter.SqlDbType = System.Data.SqlDbType.Int;
                    outputSqlParameter.Direction = ParameterDirection.Output;

                    DatabaseConfig.command.Parameters.Add("@produktID");
                    DatabaseConfig.command.ExecuteNonQuery();

                    int lastProduct = int.Parse( outputSqlParameter.Value.ToString());

                    return lastProduct;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
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
                    DatabaseConfig.command = new SqlCommand("usp_ShtoProdukt", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@emri", produkti.Emri);
                    DatabaseConfig.command.Parameters.AddWithValue("@cmimi", produkti.Cmimi);
                    DatabaseConfig.command.Parameters.AddWithValue("@sasia", produkti.Sasia);
                    DatabaseConfig.command.Parameters.AddWithValue("@llojiID", produkti.LlojiID);
                    DatabaseConfig.command.Parameters.AddWithValue("@userID", 1);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }

            //// loadData();
        }
    }
}
