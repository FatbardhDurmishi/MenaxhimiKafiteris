using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using MenaxhimiKafiteris.BO;
using MenaxhimiKafiteris.BLL;
=======
using MenaxhimiKafiteris.BLL;
using System.Data.SqlClient;

>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
=======

>>>>>>> parent of 0e87859 (raportet)
=======
using MenaxhimiKafiteris.BO;
using MenaxhimiKafiteris.BLL;
>>>>>>> 8f4ccb216e5bf7eeae42c9084ca885a660248332
namespace MenaxhimiKafiteris.AdminForms
{
    public partial class Porosite : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        PorosiaService porosiaService;
=======
        PorosiaServices porosiaServices;
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
=======
>>>>>>> parent of 0e87859 (raportet)
=======
        PorosiaService porosiaService;
>>>>>>> 8f4ccb216e5bf7eeae42c9084ca885a660248332
        public Porosite()
        {
            InitializeComponent();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 8f4ccb216e5bf7eeae42c9084ca885a660248332
            Refresh();
            ShfaqProduktet();
        }

        private void Porosite_Load(object sender, EventArgs e)
        {
           
        }


        public void ShfaqProduktet()
        {

            dgLlojet.DataSource = porosiaService.GetAll().Tables[0];
           
<<<<<<< HEAD
=======
            porosiaServices = new PorosiaServices();
            MerrPorosite();
        }

        public void MerrPorosite()
        {
            dgPorosite.DataSource= porosiaServices.GetAll().Tables[0];
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
=======
>>>>>>> parent of 0e87859 (raportet)
=======
>>>>>>> 8f4ccb216e5bf7eeae42c9084ca885a660248332
        }
    }
}
