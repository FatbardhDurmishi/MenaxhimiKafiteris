using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiKafiteris.BO
{
    class Tavolina
    {

        //create table Tavolina(
        //Tavolina_ID int primary key IDENTITY(1,1),
        //NrKarrigev int not null,
        //Salla_ID int foreign key references Salla(Salla_ID)
        //);

        public int nrKarrikeve { get; set; }
        public int sallaID { get; set; }
    }
}
