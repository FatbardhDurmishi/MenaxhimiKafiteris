using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiKafiteris.BO
{
    public class Porosia
    {
        public string Koha { get; set; }
        public decimal Tvsh { get; set; }
        public decimal Totali { get; set; }
        public decimal TotaliPaTvsh { get; set; }
        public int TavolinaID { get; set; }
        public int UserID { get; set; }
    }
}
