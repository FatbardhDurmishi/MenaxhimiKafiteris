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





        private void btnShto_Click_1(object sender, EventArgs e)
        {
            Sallacl newSalla = new Sallacl();
            newSalla.Emri = txtEmri.Text;
            newSalla.NrTavolinav = int.Parse(txtnrTavolinat.Text);
            bool isSaved = sallatservices.ShtoSall(newSalla);
            ShfaqSallat();
        }

        private void btnFshij_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgSallat.SelectedRows)
            {

                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                dgSallat.Rows.RemoveAt(row.Index);
                //Some salla nuk fshihen because Foreing Key constraint.
                //Nuk mujna me fshi pa i fshi edhe perdorimet e saje. Dmth kur ka tavolina ne salle, duhet me shku mi fshi tavolinat fillimisht.
                sallatservices.FshiSall(rowIndex);
                ShfaqSallat();
            }
        }
    }
}
