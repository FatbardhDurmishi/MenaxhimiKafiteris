using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiKafiteris.DAL;
using MenaxhimiKafiteris.BO;

namespace MenaxhimiKafiteris.BLL
{
    public class PorosiaServices
    {
        private PorosiaRepository porosiaRepository;
        public PorosiaServices()
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
        public int GetLastPorosi()
        {
            return porosiaRepository.GetLastPorosi();
        }
        public bool ShtoProduktetEPorosise(int produktiID,int porosiaID)
        {
            return porosiaRepository.ShtoProduktetEPorosise(produktiID,porosiaID);
        }
        public DataSet MerrPorositeEKamarierit(int id)
        {
            return porosiaRepository.PorositeEKamarierit(id);
        }
        public bool PaguajPorosin(int porosiaID)
        {
            return porosiaRepository.PaguajPorosin(porosiaID);
        }
    }
}
