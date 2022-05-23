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

namespace MenaxhimiKafiteris.AdminForms.Sallat
{
    public partial class Salla : Form
    {
        SallatServices sallatservices;
        public Salla()
        {
            sallatservices = new SallatServices();
            InitializeComponent();
            ShfaqSallat();
        }
        public void ShfaqSallat()
        {
            dgSallat.DataSource = sallatservices.GetAll().Tables[0];
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            Sallacl newSalla = new Sallacl();
            newSalla.Emri = txtEmri.Text;
            newSalla.NrTavolinav = int.Parse(txtnrTavolinat.Text);
            bool isSaved = sallatservices.ShtoSall(newSalla);
            ShfaqSallat();

        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgSallat.SelectedRows)
            {

                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                dgSallat.Rows.RemoveAt(row.Index);
                sallatservices.FshiSall(rowIndex);
                ShfaqSallat();
            }
        }



    }
}
