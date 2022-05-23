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
<<<<<<< HEAD
<<<<<<< HEAD
=======
            if (id > 0)
            {
                bool isUpdated = sallatservices.UpdateSall(newSalla, id);
                ShfaqSallat();
                txtEmri.Clear();
                txtnrTavolinat.Clear();
            }
            else
            {
                bool isSaved = sallatservices.ShtoSall(newSalla);
                if (isSaved)
                {
                    MessageBox.Show("Salla eshte shtuar me sukses");
                    ShfaqSallat();
                }
                else
                {
                    MessageBox.Show("Ka ndodhur nje problme,provoni perseri");
                }
            }
           
            

>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
=======

>>>>>>> parent of 0e87859 (raportet)
=======
>>>>>>> 8f4ccb216e5bf7eeae42c9084ca885a660248332
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        //public void PopulateOnEdit()
        //{

        //}


        private void datagridToTextbox(object sender, DataGridViewCellMouseEventArgs e)
        {


            id = (int)dgSallat.CurrentRow.Cells[0].Value;
            txtEmri.Text = dgSallat.CurrentRow.Cells[1].Value.ToString(); 
            txtnrTavolinat.Text = dgSallat.CurrentRow.Cells[2].Value.ToString();

        }
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
=======



>>>>>>> parent of 0e87859 (raportet)
=======
>>>>>>> 8f4ccb216e5bf7eeae42c9084ca885a660248332
    }
}
