using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiKafiteris.DAL;
using System.Data;
using System.Data.SqlClient;
using MenaxhimiKafiteris.BO;

namespace MenaxhimiKafiteris.BLL
{
    public class PorosiaService
    {
        private PorosiaRepository porosiaRepository;
        public PorosiaService()
        {
            porosiaRepository = new PorosiaRepository();
        }

        public DataSet GetAll()
        {
            return porosiaRepository.GetAll();
        }
        public bool ShtoPorosi(Porosia porosia)
        {
            return porosiaRepository.ShtoPorosi(porosia);
        }

        public DataSet GetTop()
        {
            return porosiaRepository.GetTop();
        }

        public string GetTotalin()
        {
            return porosiaRepository.GetTotalin();
        }

        public string GetTotalinPaTvsh()
        {
            return porosiaRepository.GetTotalinPaTvsh();
        }

        public string GetTopSallenEmrin()
        {
            return porosiaRepository.GetTopSallenEmrin();
        }

        public string GetTopSallenLeket()
        {
            return porosiaRepository.GetTopSallenLeket();
        }
    }
}
