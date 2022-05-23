using System;
using System.Data;
using System.Data.SqlClient;
using MenaxhimiKafiteris.BO;

namespace MenaxhimiKafiteris.DAL
{
    public class UseretRepository
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
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("usp_MerrUseret", DatabaseConfig.connection);
                    DatabaseConfig.adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool ShtoUser(Useri useri)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_ShtoUser", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@username", useri.Username);
                    DatabaseConfig.command.Parameters.AddWithValue("@passwordi", useri.Passwordi);
                    DatabaseConfig.command.Parameters.AddWithValue("@gjinia", useri.Gjinia);
                    DatabaseConfig.command.Parameters.AddWithValue("@roliID", useri.RoliID);
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
        public bool FshijUser(int id)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_DeleteStaff", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@userID", id);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool EditoUser(Useri useri,int id)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("usp_UpdateUser", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@username", useri.Username);
                    DatabaseConfig.command.Parameters.AddWithValue("@passwordi", useri.Passwordi);
                    DatabaseConfig.command.Parameters.AddWithValue("@gjinia", useri.Gjinia);
                    DatabaseConfig.command.Parameters.AddWithValue("@roliID", useri.RoliID);
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
        public Useri MerrUserin( Useri useri )
        {
            try
            {

                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    SqlCommand cmd=new SqlCommand("usp_MerrUserin",DatabaseConfig.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@username",SqlDbType.VarChar).Value=useri.Username;
                    cmd.Parameters.Add("@passwordi",SqlDbType.VarChar).Value=useri.Passwordi;
                    SqlDataAdapter da=new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        useri.RoliID=int.Parse(dt.Rows[0]["Roli_Id"].ToString());
                    }
                    cmd.ExecuteNonQuery();
                    return useri;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
