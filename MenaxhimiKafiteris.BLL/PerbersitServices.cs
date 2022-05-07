using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MenaxhimiKafiteris.DAL;

namespace MenaxhimiKafiteris.BLL
{
    internal class PerbersitServices
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
    }
}
