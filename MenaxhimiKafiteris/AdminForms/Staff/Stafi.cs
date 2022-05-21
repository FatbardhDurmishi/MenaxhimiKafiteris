﻿using System;
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
        }
        private void ShfaqUseret()
        {
            dgStafi.DataSource = useretServices.GetAll().Tables[0];
        }
        private void btnShtoStaff_Click(object sender, EventArgs e)
        {
            var formPopup = new Staffi.ShtoStaff();
            formPopup.Show(this);
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
            foreach(DataGridViewRow row in dgStafi.SelectedRows)
            {
                id = (int)row.Cells[0].Value;
                username=row.Cells[1].ToString();
                password=row.Cells[2].ToString();
                gjinia= row.Cells[3].ToString();
                roliId = (int)row.Cells[4].Value;
            }

            
            ShtoStaff frm=new Staffi.ShtoStaff();
            
            frm.Show(this);
            
        }

        private void shtoStaffBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
