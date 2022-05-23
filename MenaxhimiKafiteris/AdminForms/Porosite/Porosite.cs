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
using MenaxhimiKafiteris.BO;
using MenaxhimiKafiteris.BLL;
=======
using MenaxhimiKafiteris.BLL;
using System.Data.SqlClient;

>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
=======

>>>>>>> parent of 0e87859 (raportet)
namespace MenaxhimiKafiteris.AdminForms
{
    public partial class Porosite : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
        PorosiaService porosiaService;
=======
        PorosiaServices porosiaServices;
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
=======
>>>>>>> parent of 0e87859 (raportet)
        public Porosite()
        {
            InitializeComponent();
<<<<<<< HEAD
<<<<<<< HEAD
            Refresh();
            ShfaqProduktet();
        }

        private void Porosite_Load(object sender, EventArgs e)
        {
           
        }


        public void ShfaqProduktet()
        {

            dgLlojet.DataSource = porosiaService.GetAll().Tables[0];
           
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
        }
    }
}
