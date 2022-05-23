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
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrProduktinFundit2", DatabaseConfig.connection);
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


        public bool FshiProdukt(int ID)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_DeleteProdukt", DatabaseConfig.connection);
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
        }
        public List<Produkti> ListaProduktev()
        {

            //useri.RoliID = int.Parse(dt.Rows[0]["Roli_Id"].ToString());
            try
            { 
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    List<Produkti> list = new List<Produkti>();
                    DatabaseConfig.connection.Open();
                    SqlCommand cmd = new SqlCommand("usp_MerrProduktet", DatabaseConfig.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Produkti pr = new Produkti();
                        pr.Id = (int)dt.Rows[i]["ID"];
                        pr.Emri = dt.Rows[i]["Emri"].ToString();
                        pr.Cmimi = (decimal)dt.Rows[i]["Çmimi"];
                        pr.Lloji = dt.Rows[i]["Lloji"].ToString();
                        list.Add(pr);
                    }  
                    return list;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool UpdateSasinEProduktit(int produktiID)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_UpdateSasinEProduktit", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@produktiID", produktiID);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
    
}
