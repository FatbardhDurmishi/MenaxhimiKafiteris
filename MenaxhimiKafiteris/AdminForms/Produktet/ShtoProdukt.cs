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
            perbersitServices = new PerbersitServices();
            InitializeComponent();
            PopulloComboList();
        }
        
        private void btnShtoProdukt_Click(object sender, EventArgs e)
        {
            //Shto produktin duke krijuar new produkt
            Produkti newProdukt = new Produkti();
            newProdukt.Emri = txtEmri.Text;
            newProdukt.Cmimi = decimal.Parse(txtCmimi.Text);
            newProdukt.Sasia = int.Parse(txtSasia.Text);
            newProdukt.LlojiID = int.Parse(cbLloji.SelectedValue.ToString());
            bool isSaved = produktetServices.ShtoProdukt(newProdukt);


            //Get last product created, get its id
            //dgProduktet.DataSource = produktetServices.GetLastProdukt();
            //Tani get the other values te perbersit nga lista e perbersve, and shtoj all values ne ShtoPerberesitEProduktit();
            //forEach se mujna me pas ma shum perberes
            foreach (var perberes in perbersitList)
            {
                //Get last produkt inserted, so we know where to add the perberes
                int  produktID= produktetServices.GetLastProdukt();
                int perbersiID = perberes.ID;
                int sasia= (int) perberes.Sasia;
                
                bool savePerberesPerProdukt = perbersitServices.ShtoPerberesitEProduktit(produktID, perbersiID,  sasia);
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
        //Its subscription based thing. Subscribed to an event from the new Produktet.shtoPerberesPerProdukt();
        //Now it gets a perberes si parameter, and we add it to the list and update the text
        private void FormPopup_DataSent(Perbersi perbersi)
        {
            perbersitList.Add(perbersi);
            this.lblListaPerbersve.Text += "\n"+ perbersi.Emri + ", " + perbersi.Sasia;
        }
    }
}
