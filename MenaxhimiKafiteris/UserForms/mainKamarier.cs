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
using MenaxhimiKafiteris.LogInForm;

namespace MenaxhimiKafiteris.UserForms
{
    public partial class mainKamarier : Form
    {
        public static decimal Totali;
        PorosiaServices porosiaServices;
        //LogIn logIn;
        int userID;
        public mainKamarier()
        {
            InitializeComponent();
            //logIn = new LogIn();
            lblKamarieri.Text = LogIn.username;
            userID = LogIn.userID;
            porosiaServices = new PorosiaServices();
            MerrPorosite();
        }
        public void MerrPorosite()
        {
            dgPorosite.DataSource = porosiaServices.MerrPorositeEKamarierit(userID).Tables[0];
        }

        private void btnPaguajPorosin_Click(object sender, EventArgs e)
        {
           
            
            foreach (DataGridViewRow row in dgPorosite.SelectedRows)
            {

                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                Totali = (decimal)row.Cells[5].Value;
                porosiaServices.PaguajPorosin(rowIndex);


            }
            PaguajPorosin frm = new PaguajPorosin();
            frm.ShowDialog();
            MerrPorosite();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            krijoPorosi frm=new krijoPorosi();
            frm.ShowDialog();
            MerrPorosite();
        }
    }
}
