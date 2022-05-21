using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiKafiteris.DAL;
using System.Data;
using System.Data.SqlClient;

namespace MenaxhimiKafiteris.BLL
{
    public class RoletServices
    {
        private RoletRepository roletRepository;
        public RoletServices()
        {
            roletRepository = new RoletRepository();
        }
       public DataSet GetRolet()
        {
            return roletRepository.GetAll();
        }
    }
}
