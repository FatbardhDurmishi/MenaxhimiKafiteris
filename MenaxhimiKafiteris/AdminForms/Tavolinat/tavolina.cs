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
        public int id;
        SallatServices sallatServices;
        TavolinatServices tavolinatServices;
        public tavolina()
        {
            sallatServices = new SallatServices();
            tavolinatServices = new TavolinatServices();
            InitializeComponent();
            PopulloComboList();
            ShfaqTavolinaat();
        }
        public void ShfaqTavolinaat()
        {
            dgTavolinat.DataSource = tavolinatServices.GetAll().Tables[0];
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            Tavolina newtav=new Tavolina();
            newtav.NrKarrigave = int.Parse(txtNrUlseve.Text);
<<<<<<< HEAD
<<<<<<< HEAD
            newtav.SallaID = int.Parse(cbSalla.SelectedValue.ToString());
=======
            newtav.SallaID=int.Parse(cbSalla.SelectedValue.ToString());
>>>>>>> parent of 0e87859 (raportet)
            bool isSaved = tavolinatServices.ShtoTavolin(newtav);
            ShfaqSallat();
=======
            newtav.SallaID=int.Parse(cbSalla.SelectedValue.ToString());
            if (id > 0)
            {
                bool isUpdatet = tavolinatServices.UpdateTavolin(newtav, id);
                ShfaqTavolinaat();
                if (isUpdatet)
                {
                    MessageBox.Show("Tavolina eshte ruajtur me sukses");
                }
                else
                {
                    MessageBox.Show("Ka ndodhur nje problem");
                }
            }
            else
            {
                bool isSaved = tavolinatServices.ShtoTavolin(newtav);
                if (isSaved)
                {
                    MessageBox.Show("Salla eshte shtuar me sukses");
                    ShfaqTavolinaat();
                }
                else
                {
                    MessageBox.Show("Ka ndodhur nje problme,provoni perseri");
                }
               

            }
           
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgTavolinat.SelectedRows)
            {

                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                dgTavolinat.Rows.RemoveAt(row.Index);
                tavolinatServices.FshiTavolin(rowIndex);
                ShfaqTavolinaat();
            }
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 0e87859 (raportet)
        private void PopulloComboList()
        {
            cbSalla.DataSource = sallatServices.GetAll().Tables[0];
            cbSalla.ValueMember = "ID";
            cbSalla.DisplayMember = "Emri";

<<<<<<< HEAD
        }

        private void dgTavolinat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgTavolinat.CurrentRow.Cells[0].Value;
            txtNrUlseve.Text = dgTavolinat.CurrentRow.Cells[1].Value.ToString();
            cbSalla.SelectedValue = dgTavolinat.CurrentRow.Cells[2].Value;
        }
>>>>>>> 0b8cdc4746cc0e9adedc8fe5da48a5d6df9f1a4a
=======
           

        }
>>>>>>> parent of 0e87859 (raportet)
    }
}
