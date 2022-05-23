using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MenaxhimiKafiteris.BLL;
using MenaxhimiKafiteris.BO;

namespace MenaxhimiKafiteris.AdminForms.LLojet
{
    public partial class Llojet : Form
    {
        LlojetEProdukteveService llojetEProdukteveService;
        public Llojet()
        {
            llojetEProdukteveService = new LlojetEProdukteveService();
            InitializeComponent();
            ShfaqLlojet();

        }
        public void ShfaqLlojet()
        {
            dgLlojet.DataSource = llojetEProdukteveService.GetAll().Tables[0];
            //CustomDataGrid.DataSource = llojetEProdukteveService.GetAll().Tables[0];
        }


        private void deleteLLojinBtn_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgLlojet.SelectedRows)
            {

                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                dgLlojet.Rows.RemoveAt(row.Index);
                llojetEProdukteveService.FshiLloj(rowIndex);
                ShfaqLlojet();

            }
        }

        private void btnShto_Click_1(object sender, EventArgs e)
        {
            LlojetEProdukteve newLloj = new LlojetEProdukteve();
            newLloj.Lloji = llojiTextBox.Text;
            bool isSaved = llojetEProdukteveService.ShtoLloj(newLloj);
            ShfaqLlojet();
        }
    }
}
