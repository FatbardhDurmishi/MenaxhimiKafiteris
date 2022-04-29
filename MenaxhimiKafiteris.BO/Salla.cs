using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiKafiteris.BO
{
    class Salla
    {

        //Create table Salla(
        //Salla_ID int Primary key IDENTITY(1,1),
        //NrTavolinave int NOT NULL,
        //Emri varchar(50) NOT NULL,
        //);

        public int numTavolina { get; set; }
        public string emri { get; set; }

    }
}
