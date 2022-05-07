﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiKafiteris.DAL;
using System.Data;
using MenaxhimiKafiteris.BO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MenaxhimiKafiteris.BLL
{
    public class LlojetEProdukteveService
    {
        private LlojetEProdukteveRepository LlojetEProdukteveRepository;
        public LlojetEProdukteveService()
        {
            LlojetEProdukteveRepository=new LlojetEProdukteveRepository();
        }

        public DataSet GetAll()
        {
            return LlojetEProdukteveRepository.GetAll();
        }

        public bool ShtoLloj(LlojetEProdukteve lloji)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand(" usp_ShtoLlojTeProduktit", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@lloji", lloji.Lloji);
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
        public bool FshiLloj(int ID)
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand(" usp_DeleteLloji", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@llojiID", ID);
                    DatabaseConfig.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }

        }


    }
}
