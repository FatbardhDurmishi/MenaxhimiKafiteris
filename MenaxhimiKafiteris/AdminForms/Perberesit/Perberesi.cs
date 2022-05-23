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

namespace MenaxhimiKafiteris.AdminForms.Perberesit
{
    public partial class Perberesi : Form
    {
        PerbersitServices perbersiservices;
        public Perberesi()
        {
            perbersiservices = new PerbersitServices();
            InitializeComponent();
            ShfaqPerbersit();
        }


        public void ShfaqPerbersit()
        {
            dgPerbersi.DataSource = perbersiservices.GetAll().Tables[0];
        }

        private void btnShto_Click_1(object sender, EventArgs e)
        {
            Perbersi newPerbers = new Perbersi();
            newPerbers.Emri = txtPerbersi.Text;
            newPerbers.Sasia=decimal.Parse(txtSasia.Text);
            bool isSaved = perbersiservices.ShtoPerbers(newPerbers);
            ShfaqPerbersit();
            txtPerbersi.Clear();
            txtSasia.Clear();
        }


        private void btnFshij_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgPerbersi.SelectedRows)
            {

                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                dgPerbersi.Rows.RemoveAt(row.Index);
                perbersiservices.FshiPerbers(rowIndex);

            }
        }

    }
}
