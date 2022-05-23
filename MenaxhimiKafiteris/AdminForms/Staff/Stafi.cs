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

namespace MenaxhimiKafiteris.AdminForms.Staffi
{
    public partial class Stafi : Form
    {
        public static int id;
        public static string username = "";
        public static string password = "";
        public static string gjinia = "";
        public static int roliId;
        UseretServices useretServices;
        public Stafi()
        {
            InitializeComponent();
            useretServices = new UseretServices();
            dgStafi.ClearSelection();
            ShfaqUseret();
            this.Refresh();
        }
        public void ShfaqUseret()
        {
            dgStafi.DataSource = useretServices.GetAll().Tables[0];
        }
        private void btnShtoStaff_Click(object sender, EventArgs e)
        {
            var formPopup = new Staffi.ShtoStaff();
            formPopup.Visible = false;
            formPopup.ShowDialog();
        }

        private void btnFshijStaff_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgStafi.SelectedRows)
            {

                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                dgStafi.Rows.RemoveAt(row.Index);
                useretServices.FshijUser(rowIndex);
                ShfaqUseret();
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgStafi.SelectedRows)
            {
                id = (int)row.Cells[0].Value;
                username = row.Cells[1].Value.ToString();
                password = row.Cells[2].Value.ToString();
                gjinia = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString().Equals("Admin"))
                {
                    roliId = 1;
                }
                else if (row.Cells[4].Value.ToString().Equals("Kamarier"))
                {
                    roliId = 2;
                }
            }


            ShtoStaff frm = new ShtoStaff();
            frm.Visible = false;
            frm.ShowDialog();
            //this.Enabled = false;
            id = 0;
            username = null;
            password = null;
            gjinia = null;
            roliId=0;

        }


    }
}
