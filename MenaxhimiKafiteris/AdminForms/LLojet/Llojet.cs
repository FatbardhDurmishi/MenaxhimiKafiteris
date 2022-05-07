using MenaxhimiKafiteris.DAL;
using MenaxhimiKafiteris.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MenaxhimiKafiteris.AdminForms.LLojet
{
    public partial class Llojet : Form
    {
        public Llojet()
        {
            InitializeComponent();
        }

        private void Llojet_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    //Stored procedure spGetLLojetProdukteve
                    SqlCommand cmd = new SqlCommand("spGetLLojetProdukteve", DatabaseConfig.connection);
                    DatabaseConfig.connection.Open();
                    //Dataset is inmemory repersentation of tables.
                    DataSet ds = new DataSet();

                    //SqlDataReader rdr = cmd.ExecuteReader();
                    //BindingSource sauce = new BindingSource();


                    DatabaseConfig.adapter = new SqlDataAdapter();
                    DatabaseConfig.adapter.SelectCommand = new SqlCommand("spGetLLojetProdukteve", DatabaseConfig.connection);
                    //dataAdapter fill closes and opens the connection itself
                    DatabaseConfig.adapter.Fill(ds);

                    llojetDataGrid.DataSource = ds.Tables[0];
                }
            }
            catch
            {

            }
        }
        private void llojetDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string lloji = llojiTextBox.Text;
            try
            {
                //Using closes it vet. Forces it to close itself
                using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    DatabaseConfig.connection.Open();
                    DatabaseConfig.command = new SqlCommand("spAddLlojetProdukteve", DatabaseConfig.connection);
                    DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                    //Stored procedure spGetLLojetProdukteve
                    DatabaseConfig.command.Parameters.AddWithValue("@lloji", lloji);
                    DatabaseConfig.command.ExecuteNonQuery();
                }
            }
            catch
            {

            }

            loadData();
        }

        private void deleteLLojinBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in llojetDataGrid.SelectedRows)
            {
       
                //gets index from cells
                int rowIndex = (int)row.Cells[0].Value;
                llojetDataGrid.Rows.RemoveAt(row.Index);

                try
                {
                    //Using closes it vet. Forces it to close itself
                    using (DatabaseConfig.connection = new SqlConnection(DatabaseConfig.ConnectionString))
                    {
                        DatabaseConfig.connection.Open();
                        DatabaseConfig.command = new SqlCommand("usp_DeleteLloji", DatabaseConfig.connection);
                        DatabaseConfig.command.CommandType = System.Data.CommandType.StoredProcedure;

                        //Stored procedure spGetLLojetProdukteve
                        DatabaseConfig.command.Parameters.AddWithValue("@llojiID", rowIndex );
                        DatabaseConfig.command.ExecuteNonQuery();
                    }
                }
                catch
                {

                }

                loadData();
            }
        }
    }
}
