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
using MenaxhimiKafiteris.BO;

namespace MenaxhimiKafiteris.AdminForms.Tavolinat
{
    public partial class tavolina : Form
    {
        SallatServices sallatServices;
        TavolinatServices tavolinatServices;
        public tavolina()
        {
            sallatServices = new SallatServices();
            tavolinatServices = new TavolinatServices();
            InitializeComponent();
            PopulloComboList();
            ShfaqSallat();
        }
        public void ShfaqSallat()
        {
            dgTavolinat.DataSource = tavolinatServices.GetAll().Tables[0];
        }




        private void PopulloComboList()
        {
            cbSalla.DataSource = sallatServices.GetAll().Tables[0];
            cbSalla.ValueMember = "ID";
            cbSalla.DisplayMember = "Emri";

           

        }

        private void dgTavolinat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShto_Click_1(object sender, EventArgs e)
        {
            Tavolina newtav = new Tavolina();
            newtav.NrKarrigave = int.Parse(txtNrUlseve.Text);
            newtav.SallaID = int.Parse(cbSalla.SelectedValue.ToString());
            bool isSaved = tavolinatServices.ShtoTavolin(newtav);
            ShfaqSallat();
        }

        private void btnFshij_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgTavolinat.SelectedRows)
            {

                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                dgTavolinat.Rows.RemoveAt(row.Index);
                tavolinatServices.FshiTavolin(rowIndex);
                ShfaqSallat();
            }
        }
    }
}
