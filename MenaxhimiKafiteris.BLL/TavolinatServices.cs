using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiKafiteris.DAL;
using System.Data;
using MenaxhimiKafiteris.BLL;
using MenaxhimiKafiteris.BO;
using System.Data.SqlClient;

namespace MenaxhimiKafiteris.BLL

{
    public class TavolinatServices
    {
        private TavolinatRepository _tavolinatRepository;
        public TavolinatServices()
        {
            _tavolinatRepository = new TavolinatRepository();
        }
        public DataSet GetAll()
        {
            return _tavolinatRepository.GetAll();
        }
        public bool ShtoTavolin(Tavolina tavolina)
        {
            return _tavolinatRepository.ShtoTavolin(tavolina);
        }
        public bool FshiTavolin(int id)
        {
            return _tavolinatRepository.FshiTavolin(id);
        }
        public bool UpdateTavolin(Tavolina tavolina,int id)
        {
            return _tavolinatRepository.UpdateTavolin(tavolina,id);
        }
    }
}
