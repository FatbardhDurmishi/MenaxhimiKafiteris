using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiKafiteris.BO
{
    public class Produkti
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public decimal Cmimi { get; set; }
        public int Sasia { get; set; }
        public int LlojiID { get; set; }
        public string Lloji { get; set; }
    }
}
