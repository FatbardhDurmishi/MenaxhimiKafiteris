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

        public void ShfaqProduktet()
        {
            
            dgProduktet2.DataSource = produktetServices.GetAll().Tables[0];
        }


        private void produktetForm_Load(object sender, EventArgs e)
        {

        }

        private void fshijProduktinBtn_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgProduktet2.SelectedRows)
            {

                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                dgProduktet2.Rows.RemoveAt(row.Index);
                produktetServices.FshiProdukt(rowIndex);


            }
        }

        private void shtoProduktinBtn_Click_1(object sender, EventArgs e)
        {
            var formPopup = new Produktet.ShtoProdukt();
            formPopup.ShowDialog();
            ShfaqProduktet();

        }
    }
}
