using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiKafiteris.DAL;
using System.Data;

namespace MenaxhimiKafiteris.BLL
{
    internal class TavolinatServices
    {
        private TavolinatRepository _talolinatRepository;
        public TavolinatServices()
        {
            _talolinatRepository = new TavolinatRepository();
        }
        public DataSet GetAll()
        {
            return _talolinatRepository.GetAll();
        }
    }
}
