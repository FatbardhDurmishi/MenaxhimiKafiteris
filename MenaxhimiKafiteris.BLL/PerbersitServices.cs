using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MenaxhimiKafiteris.DAL;
using System.Data.SqlClient;
using MenaxhimiKafiteris.BO;

namespace MenaxhimiKafiteris.BLL
{
    public class PerbersitServices
    {
        private PerbersitRepository perbersitRepository;
        public PerbersitServices()
        {
            perbersitRepository = new PerbersitRepository();
        }
        public DataSet GetAll()
        {
            return perbersitRepository.GetAll();
        }
        
        public bool FshiPerbers(int id)
        {
           return perbersitRepository.FshiPerbers(id);
        }
        public bool ShtoPerbers(Perbersi perbers)
        {
           return perbersitRepository.ShtoPerbers(perbers);
        }

        public bool ShtoPerberesitEProduktit(int perberes_ID, int produkt_ID, int sasia)
        {
            return perbersitRepository.ShtoPerberesitEProduktit(perberes_ID, produkt_ID, sasia);
        }

        //public bool FshiPerbers(int ID)
        //{
        //    try
        //    {
        //        //Using closes it vet. Forces it to close itself
        //        using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
        //        {
        //            DatabaseConfig.connection.Open();
        //            DatabaseConfig.command = new SqlCommand("usp_DeletePerbers", DatabaseConfig.connection);
        //            DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

        //            //Stored procedure spGetLLojetProdukteve
        //            DatabaseConfig.command.Parameters.AddWithValue("@perbersiID", ID);
        //            DatabaseConfig.command.ExecuteNonQuery();
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //}
        //public bool ShtoPerbers(Perbersi perbersi)
        //{
        //    try
        //    {
        //        //Using closes it vet. Forces it to close itself
        //        using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
        //        {
        //            DatabaseConfig.connection.Open();
        //            DatabaseConfig.command = new SqlCommand("usp_ShtoPerberes", DatabaseConfig.connection);
        //            DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

        //            //Stored procedure spGetLLojetProdukteve
        //            DatabaseConfig.command.Parameters.AddWithValue("@emri", perbersi.Emri);
        //            DatabaseConfig.command.Parameters.AddWithValue("@sasia", perbersi.Sasia);
        //            DatabaseConfig.command.Parameters.AddWithValue("@userID", 1);
        //            DatabaseConfig.command.ExecuteNonQuery();
        //            return true;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //    // loadData();
        //}
    }
}
