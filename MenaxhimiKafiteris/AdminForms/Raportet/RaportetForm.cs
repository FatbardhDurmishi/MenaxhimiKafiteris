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

namespace MenaxhimiKafiteris.AdminForms.Raportet
{
    public partial class RaportetForm : Form
    {

        PorosiaService porosiaService;
        ProduktetServices produktetServices;
        public RaportetForm()
        {
            porosiaService = new PorosiaService();
            produktetServices = new ProduktetServices();
            InitializeComponent();
            ShfaqProduktet();
        }


        public void ShfaqProduktet()
        {

            //dgProduktet2.DataSource = produktetServices.GetAll().Tables[0];
            //chart1.Series
            //dgPerbersit.DataSource = perbersiservices.GetAll().Tables[0];
            //chart4.DataSource = 
            //chart4.Series[]
            //chart4.DataSource = porosiaService.GetAll()..

            //view_KamarieratDheTotalins the view ne DB
            DbChartDataContext db = new DbChartDataContext();
            chart4.DataSource = db.view_KamarieratDheTotalins.ToList();
            chart4.Titles.Add("Kamarierat dhe totali i tyre gjithsej");
            chart4.Series["Totali"].XValueMember = "Kamarieri";
            chart4.Series["Totali"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart4.Series["Totali"].YValueMembers = "Totali";
            chart4.Series["Totali"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            chart3.DataSource = db.view_ShitjetPerTavolines.ToList();
            chart3.Titles.Add("Tavolinat me me se shumti shitje");
            chart3.Series["ID"].XValueMember = "TavolinaID";
            chart3.Series["ID"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart3.Series["ID"].YValueMembers = "Totali";
            chart3.Series["ID"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;


            chart2.DataSource = db.view_topKategoriteMeShitjes.ToList();
            chart2.Titles.Add("Top kategorite per total shitje");
            chart2.Series["Sasia"].XValueMember = "Lloji";
            chart2.Series["Sasia"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series["Sasia"].YValueMembers = "sasia";
            chart2.Series["Sasia"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            chart1.DataSource = db.view_TotalOrdersLast7Days.ToList();
            chart1.Titles.Add("Totali i numrit te porosive gjate 7 diteve te fundit");
            chart1.Series["Orders"].XValueMember = "DayofYear_OrderDate";
            chart1.Series["Orders"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series["Orders"].YValueMembers = "nr_Porosive";
            chart1.Series["Orders"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            //lblTopProductName

            //dgSallat.DataSource = sallatservices.GetAll().Tables[0];
            dgPorosite.DataSource = porosiaService.GetTop().Tables[0];

            //Fill the labels with data
            lblTopProductName.Text = produktetServices.GetTopProduktName();
            lblTopProductSasia.Text = produktetServices.GetTopProdukSasia() + " orders";

            lblTotali.Text += porosiaService.GetTotalin();
            lblTotaliPaTvsh.Text += porosiaService.GetTotalinPaTvsh() + " pa tvsh";

            lblEmriSalles.Text = porosiaService.GetTopSallenEmrin();
            lblLeketSalles.Text += porosiaService.GetTopSallenLeket();

        }

        //Resize Event
        private void Form1_Resize(object sender, EventArgs e)
        {
            //...
        }
        //ResizeEnd Event

        //Maximize & Restore "Event"
        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MAXIMIZE = 0xF030;
        const int SC_RESTORE = 0xF120;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_SYSCOMMAND)
            {
                if (m.WParam == (IntPtr)SC_MAXIMIZE || m.WParam == (IntPtr)SC_RESTORE)
                    this.OnResizeEnd(EventArgs.Empty);
            }
        }
        //Responsive Form Finish Method
        private void ResponsiveEnd()
        {
            if (this.Width <= 450)
            {
                tableLayoutPanel2.ColumnStyles[1].Width = 350;

            }
            else if (this.Width < 1308)
            {
                tableLayoutPanel2.ColumnStyles[1].Width = tableLayoutPanel2.Width - (chart1.Width + chart2.Margin.Right);
            }
            else
            {
                tableLayoutPanel2.ColumnStyles[1].Width = tableLayoutPanel2.Width - (chart1.Width + chart2.Width + chart1.Margin.Right + chart2.Margin.Right +10);
            }

            if (this.Height <= 775)
            {
                panel8.Height = 290;
            }
            else
            {
                panel8.Height = panel7.Height;
            }
        }

        private void RaportetForm_ResizeEnd(object sender, EventArgs e)
        {
            ResponsiveEnd();
        }

        private void RaportetForm_Resize(object sender, EventArgs e)
        {
            ResponsiveEnd();
        }

        private void RaportetForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
