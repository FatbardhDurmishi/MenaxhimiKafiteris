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
    public class PerbersitRepository
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
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrPerbersit", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool FshiPerbers(int ID)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_DeletePerbers", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@perbersiID", ID);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool ShtoPerberesitEProduktit(int perberes_ID, int produkt_ID, int sasia)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_DeletePerbers", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@perbersiID", perberes_ID);
                    DatabaseConfig.command.Parameters.AddWithValue("@produkti_ID", produkt_ID);
                    DatabaseConfig.command.Parameters.AddWithValue("@sasia", sasia);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch 
            {
                return false;
            }

        }

        public bool ShtoPerbers(Perbersi perbersi)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_ShtoPerberes", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@emri", perbersi.Emri);
                    DatabaseConfig.command.Parameters.AddWithValue("@sasia", perbersi.Sasia);
                    DatabaseConfig.command.Parameters.AddWithValue("@userID", 1);
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
