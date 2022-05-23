using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiKafiteris.BO;
using MenaxhimiKafiteris.BLL;
namespace MenaxhimiKafiteris.AdminForms
{
    public partial class Porosite : Form
    {
        PorosiaService porosiaService;
        public Porosite()
        {
            porosiaService = new PorosiaService();
            InitializeComponent();
            Refresh();
            ShfaqProduktet();
        }

        private void Porosite_Load(object sender, EventArgs e)
        {
           
        }


        public void ShfaqProduktet()
        {

            dgLlojet.DataSource = porosiaService.GetAll().Tables[0];
           
        }
    }
}
