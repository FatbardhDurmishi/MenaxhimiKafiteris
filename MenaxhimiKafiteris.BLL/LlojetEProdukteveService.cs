using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiKafiteris.DAL;
using System.Data;

namespace MenaxhimiKafiteris.BLL
{
    internal class LlojetEProdukteveService
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
    }
}
