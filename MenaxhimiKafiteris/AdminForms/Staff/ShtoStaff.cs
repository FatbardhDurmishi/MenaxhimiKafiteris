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

namespace MenaxhimiKafiteris.AdminForms.Staffi
{
    public partial class ShtoStaff : Form
    {
        UseretServices useretServices;
        RoletServices roletServices;
        public ShtoStaff()
        {
            
            InitializeComponent();
            useretServices = new UseretServices();
            roletServices = new RoletServices();
            PopulloComboList();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            Useri newUser = new Useri
            {
                Username = txtUsername.Text,
                Passwordi = txtPasswordi.Text,
                Gjinia = txtGjinia.Text,
                RoliID = cbRoli.SelectedIndex

            };
            if (Stafi.id > 0)
            {
                if(useretServices.EditoUser(newUser, Stafi.id))
                {
                    MessageBox.Show("Useri eshte edituar me suskes");
                } 
            }
            else
            {
                if (useretServices.ShtoUser(newUser))
                {
                    MessageBox.Show("Useri eshte shtuar me sukses");
                }
            }
           
           
           
            this.Close();
        }
        private void PopulloComboList()
        {
            cbRoli.ValueMember = "ID";
            cbRoli.DisplayMember = "Roli";

            cbRoli.DataSource = roletServices.GetRolet().Tables[0];

        }
        public void PopulateOnEdit()
        {
            txtUsername.Text = Stafi.username;
            txtPasswordi.Text = Stafi.password;
            txtGjinia.Text = Stafi.gjinia;
            cbRoli.SelectedIndex =Stafi.roliId;
            this.Show();
        }
    }
}
