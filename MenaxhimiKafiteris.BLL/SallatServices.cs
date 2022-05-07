using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MenaxhimiKafiteris.DAL;

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
    }
}
