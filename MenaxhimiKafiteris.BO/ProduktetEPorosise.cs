using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiKafiteris.BO
{
    class ProduktetEPorosise
    {

        //create table ProduktetEPorosise(
        //Produkti_ID int Foreign key references Produktet(Produkti_ID),
        //Porosia_ID int foreign key references Porosia(Porosia_ID),
        //Sasia int not null
        //);

        public int produktiID { get; set; }
        public int porosiaID { get; set; }
        public decimal sasia { get; set; }
    }
}
