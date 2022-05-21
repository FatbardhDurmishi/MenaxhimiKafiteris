using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiKafiteris.DAL;
using System.Data;
using MenaxhimiKafiteris.BO;

namespace MenaxhimiKafiteris.BLL
{
    public class UseretServices
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
        public bool ShtoUser(Useri useri)
        {
            return useretRepository.ShtoUser(useri);
        }
        public bool FshijUser(int id)
        {
            return useretRepository.FshijUser(id);
        }
        public bool EditoUser(Useri user, int id)
        {
            return useretRepository.EditoUser(user, id);
        }
        public Useri MerrUserin(Useri useri)
        {
            return useretRepository.MerrUserin(useri);
        }
    }
}
