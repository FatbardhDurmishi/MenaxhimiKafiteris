using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiKafiteris.DAL;
using System.Data;

namespace MenaxhimiKafiteris.BLL
{
    public class ProduktetServices
    {
        private ProduktetRepository produktetRepository;
        public ProduktetServices()
        {
            produktetRepository = new ProduktetRepository();
        }
        public DataSet GetAll()
        {
            return produktetRepository.GetAll();
        }
    }
    
}
