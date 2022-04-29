using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiKafiteris.BO
{
    internal class Produktet
    {
//        create table Produktet(
//Produkti_ID int PRIMARY KEY IDENTITY(1,1),
//Emri varchar(50) not null,
//Cmimi decimal not null,
//Lloji_ID int Foreign key references LlojetProdukteve(Lloji_ID));

            public string Emri { get; set; }
        public decimal Cmimi { get; set; }
        public int LlojiId { get; set; }
    }
}
