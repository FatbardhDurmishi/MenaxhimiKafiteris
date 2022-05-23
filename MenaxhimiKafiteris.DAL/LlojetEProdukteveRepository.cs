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
    public class LlojetEProdukteveRepository
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
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrLlojetEprodukteve", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool ShtoLloj(LlojetEProdukteve lloji)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_ShtoLlojTeProduktit", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@lloji", lloji.Lloji);
                    DatabaseConfig.command.Parameters.AddWithValue("@userID", 1);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            // loadData();
        }
        public bool FshiLloj(int ID)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_DeleteLloji", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@llojiID", ID);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public List<LlojetEProdukteve> ListaLlojetProduktev()
        {

            //useri.RoliID = int.Parse(dt.Rows[0]["Roli_Id"].ToString());
            try
            {
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    List<LlojetEProdukteve> list = new List<LlojetEProdukteve>();
                    DatabaseConfig.connection.Open();
                    SqlCommand cmd = new SqlCommand("usp_MerrLlojetEprodukteve", DatabaseConfig.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        LlojetEProdukteve lloji = new LlojetEProdukteve();
                        lloji.ID = (int)dt.Rows[i]["ID"];
                        lloji.Lloji = dt.Rows[i]["Kategoria"].ToString();

                        list.Add(lloji);
                    }
                    //foreach (DataRow row in dt.Rows)
                    //{
                    //    lloji.ID = (int)dt.Rows[0]["ID"];
                    //    lloji.Lloji = dt.Rows[0]["Kategoria"].ToString();
                       
                    //    list.Add(lloji);
                    //}

                    return list;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

