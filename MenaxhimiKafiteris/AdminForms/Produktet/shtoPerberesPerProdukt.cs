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

namespace MenaxhimiKafiteris.AdminForms.Produktet
{
    //Create delegate then add the same type of event of that shiz.
    public delegate void DataSendhandler(Perbersi perbersi);
    public partial class shtoPerberesPerProdukt : Form
    {
        PerbersitServices perbersiservices;
        //Event si delegat. Kjo sherben me komuniku prej 2 formave. Now we are at child form, and parent form 
        //has subscribed to the event
        public event DataSendhandler DataSent;

        public shtoPerberesPerProdukt()
        {
            perbersiservices = new PerbersitServices();
            InitializeComponent();
            ShfaqPerbersit();
        }

        public void ShfaqPerbersit()
        {
            dgPerbersit.DataSource = perbersiservices.GetAll().Tables[0];
        }

        private void btnShtoPerberes_Click(object sender, EventArgs e)
        {
            //Create new perberes and add it to DataSent.
            Perbersi perbersi1 = new Perbersi();
            foreach (DataGridViewRow row in dgPerbersit.SelectedRows)
            {

                //gets index from cells
                int id = (int)row.Cells[0].Value;
                string emri = (string)row.Cells[1].Value;
                int sasia = int.Parse(tbSasia.Text);
                perbersi1.ID = id;
                perbersi1.Emri = emri;
                perbersi1.Sasia = sasia;

            }
            //Sends to all the listeners
            this.DataSent(perbersi1);
            this.Close();

        }
    }
}
