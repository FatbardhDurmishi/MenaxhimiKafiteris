using MenaxhimiKafiteris.DAL;
using System.Data;
using MenaxhimiKafiteris.BO;
using System.Collections.Generic;

namespace MenaxhimiKafiteris.BLL
{
    public class LlojetEProdukteveService
    {
        private LlojetEProdukteveRepository llojetEprodukteveRepository;
        public LlojetEProdukteveService()
        {
            llojetEprodukteveRepository=new LlojetEProdukteveRepository();
        }

        public DataSet GetAll()
        {
            return llojetEprodukteveRepository.GetAll();
        }
        public bool ShtoLloj(LlojetEProdukteve lloji)
        {
            return llojetEprodukteveRepository.ShtoLloj(lloji);
        }
        public bool FshiLloj(int id)
        {
            return llojetEprodukteveRepository.FshiLloj(id);
        }
        public List<LlojetEProdukteve> ListLlojetProdukteve()
        {
            return llojetEprodukteveRepository.ListaLlojetProduktev();
        }

        //public bool ShtoLloj(LlojetEProdukteve lloji)
        //{
        //    try
        //    {
        //        //Using closes it vet. Forces it to close itself
        //        using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
        //        {
        //            DatabaseConfig.connection.Open();
        //            DatabaseConfig.command = new SqlCommand("usp_ShtoLlojTeProduktit", DatabaseConfig.connection);
        //            DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

        //            //Stored procedure spGetLLojetProdukteve
        //            DatabaseConfig.command.Parameters.AddWithValue("@lloji", lloji.Lloji);
        //            DatabaseConfig.command.Parameters.AddWithValue("@userID", 1);
        //            DatabaseConfig.command.ExecuteNonQuery();
        //            return true;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        return false;
        //    }

        //   // loadData();
        //}
        //public bool FshiLloj(int ID)
        //{
        //    try
        //    {
        //        //Using closes it vet. Forces it to close itself
        //        using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
        //        {
        //            DatabaseConfig.connection.Open();
        //            DatabaseConfig.command = new SqlCommand("usp_DeleteLloji", DatabaseConfig.connection);
        //            DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

        //            //Stored procedure spGetLLojetProdukteve
        //            DatabaseConfig.command.Parameters.AddWithValue("@llojiID", ID);
        //            DatabaseConfig.command.ExecuteNonQuery();
        //            return true;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        return false;
        //    }

        //}


    }
}
