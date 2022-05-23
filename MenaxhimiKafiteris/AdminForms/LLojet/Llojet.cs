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
            llojetDataGrid.DataSource = llojetEProdukteveService.GetAll().Tables[0];
        }



        private void btnShto_Click(object sender, EventArgs e)
        {
            LlojetEProdukteve newLloj = new LlojetEProdukteve();
            newLloj.Lloji = llojiTextBox.Text;
            bool isSaved = llojetEProdukteveService.ShtoLloj(newLloj);
            ShfaqLlojet();
        }

        private void deleteLLojinBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in llojetDataGrid.SelectedRows)
            {

                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                llojetDataGrid.Rows.RemoveAt(row.Index);
                llojetEProdukteveService.FshiLloj(rowIndex);
                ShfaqLlojet();

            }
        }
    }
}
