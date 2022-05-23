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
    public class SallatServices
    {
        private SallatRepository sallatRepository;
        public SallatServices()
        {
            sallatRepository = new SallatRepository();
        }
        public DataSet GetAll()
        {
            return sallatRepository.GetAll();
        }
        public bool FshiSall(int id)
        {
            return sallatRepository.FshiSall(id);
        }
        public bool ShtoSall(Sallacl salla)
        {
            return sallatRepository.ShtoSall(salla);
        }
        public bool UpdateSall(Sallacl salla,int id)
        {
            return sallatRepository.UpdateSall(salla,id);
        }
        //public bool FshiSall(int ID)
        //{
        //    try
        //    {
        //        //Using closes it vet. Forces it to close itself
        //        using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
        //        {
        //            DatabaseConfig.connection.Open();
        //            DatabaseConfig.command = new SqlCommand("usp_DeleteSalla", DatabaseConfig.connection);
        //            DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

        //            //Stored procedure spGetLLojetProdukteve
        //            DatabaseConfig.command.Parameters.AddWithValue("@sallaID", ID);
        //            DatabaseConfig.command.ExecuteNonQuery();
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //}
        //public bool ShtoSall(Sallacl  salla)
        //{
        //    try
        //    {
        //        //Using closes it vet. Forces it to close itself
        //        using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
        //        {
        //            DatabaseConfig.connection.Open();
        //            DatabaseConfig.command = new SqlCommand("usp_ShtoSall", DatabaseConfig.connection);
        //            DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

        //            //Stored procedure spGetLLojetProdukteve
        //            DatabaseConfig.command.Parameters.AddWithValue("@emri", salla.Emri);
        //            DatabaseConfig.command.Parameters.AddWithValue("@nrTavolinav", salla.NrTavolinav);
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
