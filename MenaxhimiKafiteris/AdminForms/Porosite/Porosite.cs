using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiKafiteris.BLL;
using System.Data.SqlClient;

namespace MenaxhimiKafiteris.AdminForms
{
    public partial class Porosite : Form
    {
        PorosiaServices porosiaServices;
        public Porosite()
        {
            InitializeComponent();
            porosiaServices = new PorosiaServices();
            MerrPorosite();
        }

        public void MerrPorosite()
        {
            dgPorosite.DataSource= porosiaServices.GetAll().Tables[0];
        }
    }
}
