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

    public partial class produktetForm : Form
    {          
        ProduktetServices produktetServices;
        public produktetForm()
        {
            produktetServices = new ProduktetServices();
            InitializeComponent();
            Refresh();
            ShfaqProduktet();
            
        }

        private void shtoProduktinBtn_Click(object sender, EventArgs e)
        {
            var formPopup = new Produktet.ShtoProdukt();
            formPopup.Show(this);
            ShfaqProduktet();

        }
        public void ShfaqProduktet()
        {
            dgProduktet.DataSource = produktetServices.GetAll().Tables[0];
        }

        private void fshijProduktinBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgProduktet.SelectedRows)
            {

                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                dgProduktet.Rows.RemoveAt(row.Index);
                produktetServices.FshiProdukt(rowIndex);
               

            }
           
        }
    }
}
