using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Data.SqlClient;
using MenaxhimiKafiteris.BO;
using System.Data;
=======
using System.Data;
using System.Data.SqlClient;
using MenaxhimiKafiteris.BO;
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a

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
<<<<<<< HEAD

        public DataSet GetTop()
        {
=======
        public DataSet PorositeEKamarierit(int userid)
        {

>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
            try
            {
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DataSet ds = new DataSet();
                    DatabaseConfig.adapter = new SqlDataAdapter();
<<<<<<< HEAD
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrTopPorosite", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
=======
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
                   
                    
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
<<<<<<< HEAD

        public string GetTopSallenLeket()
        {
            try
            {
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DataSet ds = new DataSet();
                    DatabaseConfig.adapter = new SqlDataAdapter();
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_TopSalla", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    string stringID = ds.Tables[0].Rows[0][1].ToString();
                    return stringID;
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string GetTopSallenEmrin()
        {
            try
            {
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DataSet ds = new DataSet();
                    DatabaseConfig.adapter = new SqlDataAdapter();
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_TopSalla", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    string stringID = ds.Tables[0].Rows[0][0].ToString();
                    return stringID;
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string GetTotalin()
        {
            try
            {
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DataSet ds = new DataSet();
                    DatabaseConfig.adapter = new SqlDataAdapter();
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrTotalinStatistika", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    string stringID = ds.Tables[0].Rows[0][0].ToString();
                    return stringID;
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string GetTotalinPaTvsh()
        {
            try
            {
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DataSet ds = new DataSet();
                    DatabaseConfig.adapter = new SqlDataAdapter();
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrTotalinStatistika", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    string stringID = ds.Tables[0].Rows[0][1].ToString();
                    return stringID;
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public DataSet GetProfitPerKamarier()
        {

            try
            {
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DataSet ds = new DataSet();
                    DatabaseConfig.adapter = new SqlDataAdapter();
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrKamarieratDheTotalin", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

=======
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
        public bool ShtoPorosi(Porosia porosia)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_ShtoPorosi", DatabaseConfig.connection);
<<<<<<< HEAD
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@tvsh", porosia.Tvsh);
                    DatabaseConfig.command.Parameters.AddWithValue("@totali", porosia.CmimiTotal);
                    DatabaseConfig.command.Parameters.AddWithValue("@totalipatvsh", porosia.CmimiPaTvsh);
                    DatabaseConfig.command.Parameters.AddWithValue("@userID", porosia.UserID);
                    DatabaseConfig.command.Parameters.AddWithValue("@tavolnaID", porosia.TavolinaID);
=======
                    
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@tvsh",Porosia.Tvsh );
                    DatabaseConfig.command.Parameters.AddWithValue("@totali",porosia.CmimiTotal);
                    DatabaseConfig.command.Parameters.AddWithValue("@totalipatvsh",porosia.CmimiPaTvsh);
                    DatabaseConfig.command.Parameters.AddWithValue("@userID",porosia.UserID);
                    DatabaseConfig.command.Parameters.AddWithValue("@tavolinaID",porosia.TavolinaID);
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
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

<<<<<<< HEAD
        public bool ShtoProduktetEPorosise(int produktiID, int porosiaID)
=======
        public bool ShtoProduktetEPorosise(int produktiID,int porosiaID)
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
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
<<<<<<< HEAD
                    DatabaseConfig.command.Parameters.AddWithValue("@produktiID", produktiID);
=======
                    DatabaseConfig.command.Parameters.AddWithValue("@produktiID",produktiID);
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
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
<<<<<<< HEAD
    }
}

=======
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
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
