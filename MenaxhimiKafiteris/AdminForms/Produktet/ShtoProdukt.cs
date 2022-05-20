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

namespace MenaxhimiKafiteris.AdminForms.Produktet
{
    public partial class ShtoProdukt : Form
    {
        List<Perbersi> perbersitList = new List<Perbersi>();
        PerbersitServices perbersitServices;
        ProduktetServices produktetServices;
        LlojetEProdukteveService llojetEProdukteveService;
        public ShtoProdukt()
        {
            llojetEProdukteveService = new LlojetEProdukteveService();
            produktetServices = new ProduktetServices();
            InitializeComponent();
            PopulloComboList();
        }
        
        private void btnShtoProdukt_Click(object sender, EventArgs e)
        {

            Produkti newProdukt = new Produkti();
            newProdukt.Emri = txtEmri.Text;
            newProdukt.Cmimi = decimal.Parse(txtCmimi.Text);
            newProdukt.Sasia = int.Parse(txtSasia.Text);
            newProdukt.LlojiID = int.Parse(cbLloji.SelectedValue.ToString());
            bool isSaved = produktetServices.ShtoProdukt(newProdukt);


            //Get last product created, get its id
            //dgProduktet.DataSource = produktetServices.GetLast().Tables[0];
            foreach (var perberes in perbersitList)
            {
                int  lastInsertionID= produktetServices.GetLastProdukt();
                PerbersitEProdukteve perbersitEProdukteve = new PerbersitEProdukteve();
                perbersitEProdukteve.PerbersiID = 2;
                perbersitEProdukteve.SasiaPerbersit = perberes.Sasia;
                
                bool savePerberesPerProdukt = perbersitServices.ShtoPerberesitEProduktit(perbersitEProdukteve.PerbersiID,2, (int)perbersitEProdukteve.SasiaPerbersit);
            }
            this.Close();
        }
        private void PopulloComboList()
        {
            cbLloji.ValueMember = "ID";
            cbLloji.DisplayMember = "Kategoria";
            
            cbLloji.DataSource = llojetEProdukteveService.GetAll().Tables[0];

        }

        private void btnShtoPerberes_Click(object sender, EventArgs e)
        {
            var formPopup = new Produktet.shtoPerberesPerProdukt();
            formPopup.DataSent += FormPopup_DataSent;
            formPopup.ShowDialog();
        }

        //EventHandler listenes for events and adds from the other form
        private void FormPopup_DataSent(Perbersi perbersi)
        {
            perbersitList.Add(perbersi);
            this.lblListaPerbersve.Text += "\n"+ perbersi.Emri + ", " + perbersi.Sasia;
        }
    }
}
