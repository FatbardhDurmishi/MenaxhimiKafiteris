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
        public bool FshiProdukt(int id)
        {
            return produktetRepository.FshiProdukt(id);
        }
        public bool ShtoProdukt(Produkti produkti)
        {
            return produktetRepository.ShtoProdukt(produkti);
        }
        public List<Produkti> ListaProdukteve()
        {
            return produktetRepository.ListaProduktev();
        }

        public int GetLastProdukt()
        {
            return produktetRepository.GetLastProdukt();
        }

<<<<<<< HEAD
        public string GetTopProduktName()
        {
            return produktetRepository.GetTopProduktName();
        }

        public string GetTopProdukSasia()
        {
            return produktetRepository.GetTopProdukSasia();
        }


<<<<<<< HEAD
=======
        public bool UpdateSasinEProduktit(int produktiID)
        {
            return produktetRepository.UpdateSasinEProduktit(produktiID);
        }
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
=======
>>>>>>> parent of 0e87859 (raportet)
=======
>>>>>>> 8f4ccb216e5bf7eeae42c9084ca885a660248332

       
    }
    
}
