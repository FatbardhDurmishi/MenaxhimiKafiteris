using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiKafiteris.DAL;
using System.Data;

namespace MenaxhimiKafiteris.BLL
{
    internal class UseretServices
    {
        private UseretRepository useretRepository;
        public UseretServices()
        {
            useretRepository = new UseretRepository();
        }
        public DataSet GetAll()
        {
            return  useretRepository.GetAll();
        }
    }
}
