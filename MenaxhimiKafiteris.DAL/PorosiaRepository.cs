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
    public class PorosiaRepository
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
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrPorosite", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataSet PorositeEKamarierit(int userid)
        {

            try
            {
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DataSet ds = new DataSet();
                    DatabaseConfig.adapter = new SqlDataAdapter();
                    //DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrPorositeEKamarierit", DatabaseConfig.connection);
                    SqlCommand cmd = new SqlCommand("usp_MerrPorositeEKamarierit", DatabaseConfig.connection);
                    //DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userID", userid);
                    DatabaseConfig.adapter.SelectCommand = cmd;
                    //DatabaseConfig.command.Parameters.AddWithValue("@userID", userid);
                    // DatabaseConfig.command.ExecuteNonQuery();
                    //cmd.ExecuteReader();
                    
                    DatabaseConfig.adapter.Fill(ds);
                   
                    
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool ShtoPorosi(Porosia porosia)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_ShtoPorosi", DatabaseConfig.connection);
                    
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@tvsh",Porosia.Tvsh );
                    DatabaseConfig.command.Parameters.AddWithValue("@totali",porosia.CmimiTotal);
                    DatabaseConfig.command.Parameters.AddWithValue("@totalipatvsh",porosia.CmimiPaTvsh);
                    DatabaseConfig.command.Parameters.AddWithValue("@userID",porosia.UserID);
                    DatabaseConfig.command.Parameters.AddWithValue("@tavolinaID",porosia.TavolinaID);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public int GetLastPorosi()
        {
            //Call the usp_MerrProduktinFundit2 procedure, and fill the dataAdapter with a dataset.
            //Then since the stored procedure will select only 1 value, we know at what place to look in the dataset.
            //That is the first table, and row 0, column 0.
            //Thats the ID we are searching
            try
            {
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DataSet ds = new DataSet();
                    DatabaseConfig.adapter = new SqlDataAdapter();
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_GetLastPorosi", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    string stringID = ds.Tables[0].Rows[0][0].ToString();
                    int intID = int.Parse(stringID);
                    return intID;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public bool ShtoProduktetEPorosise(int produktiID,int porosiaID)
        {
            //Using closes it vet. Forces it to close itself
            using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_ShtoProduktetEPorosise", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure usp_shtoPerberesNeProdukt.
                    //Shto ne tabelen dytesore(ndermjetsuese).
                    DatabaseConfig.command.Parameters.AddWithValue("@produktiID",produktiID);
                    DatabaseConfig.command.Parameters.AddWithValue("@porosiaID", porosiaID);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public bool PaguajPorosin(int porosiaId)
        {
            using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_UpdateStatusinEPorosise", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure usp_shtoPerberesNeProdukt.
                    //Shto ne tabelen dytesore(ndermjetsuese).
                    DatabaseConfig.command.Parameters.AddWithValue("@porosiaID", porosiaId);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
