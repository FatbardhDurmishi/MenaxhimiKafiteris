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
using MenaxhimiKafiteris.AdminForms;
using MenaxhimiKafiteris.UserForms;

namespace MenaxhimiKafiteris.LogInForm
{
    public partial class LogIn : Form
    {
        UseretServices useretServices;
        public LogIn()
        {
            useretServices = new UseretServices();
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //List<Useri> logins = new List<Useri>();
            Useri useri = new Useri
            {
                Username = txtUsername.Text,
                Passwordi = txtPass.Text
            };
            useretServices.MerrUserin(useri);
            if (useri.RoliID == 1)
            {
                mainAdmin frm=new mainAdmin();
                frm.Show();
                Hide();
            }else if(useri.RoliID == 2)
            {
                mainKamarier frm=new mainKamarier();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Ky user nuk ekziston ose kredencialet jane gabim", "Useri");
                txtUsername.Clear();
                txtPass.Clear();
            }
            
          
        }

        private void btnClearTextboxat_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPass.Clear();
        }
    }
}
