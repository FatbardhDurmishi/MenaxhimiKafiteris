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
using MenaxhimiKafiteris.LogInForm;

namespace MenaxhimiKafiteris.UserForms
{
    public partial class krijoPorosi : Form
    {
        LogIn userID ;
        private decimal CmimiTotalIPorosise;
        public decimal CmimiTotal
        {
            get { return CmimiTotalIPorosise; }
            set 
            { 
                CmimiTotalIPorosise = value; 
                txtCmimiTotal.Text= String.Format("{0:c}", CmimiTotalIPorosise);
            }
        }  
        ProduktetServices produktetServices;
        LlojetEProdukteveService llojetEProdukteveService;
        List<Produkti> produktet = new List<Produkti>();
        List<LlojetEProdukteve> llojet=new List<LlojetEProdukteve>();
        private BindingList<Produkti> produktetEporosise = new BindingList<Produkti>();
        TavolinatServices tavolinatServices;
        PorosiaServices porosiaServices;
        public krijoPorosi()
        {
            InitializeComponent();
            userID = new LogIn();
            porosiaServices = new PorosiaServices();
            tavolinatServices = new TavolinatServices();    
            produktetServices = new ProduktetServices();
            llojetEProdukteveService = new LlojetEProdukteveService();           
            produktet = produktetServices.ListaProdukteve();
            llojet = llojetEProdukteveService.ListLlojetProdukteve();
            TabPannel();
            ProduktToTab();
            lstProduktetEPorosise.DataSource = produktetEporosise;
            lstProduktetEPorosise.DisplayMember = "Emri";
            PopulloComboList();
        }
        private void btnBejPorosi_Click(object sender, EventArgs e)
        {
            Porosia porosia=new Porosia();
            porosia.CmimiTotal = CmimiTotalIPorosise;
            porosia.CmimiPaTvsh = porosia.CmimiTotal - Porosia.Tvsh;
            porosia.TavolinaID=int.Parse(cbTavolina.SelectedValue.ToString());
            porosia.UserID = LogIn.userID;
            porosia.Statusi = 0;
            if (produktetEporosise.Any())
            {
                porosiaServices.ShtoPorosi(porosia);
                int porosiaID = porosiaServices.GetLastPorosi();

                foreach (Produkti produkt in lstProduktetEPorosise.Items)
                {
                    porosiaServices.ShtoProduktetEPorosise(produkt.Id, porosiaID);
                }
                foreach (Produkti produkt in lstProduktetEPorosise.Items)
                {
                    produktetServices.UpdateSasinEProduktit(produkt.Id);
                }
                //foreach(var produkt in produktetEporosise)
                //{
                //    produktet.Remove(produkt);
                //}
                produktetEporosise.Clear();
                CmimiTotal = 0;
                MessageBox.Show("Porosia eshte kryer me sukses");
                this.Close();
            }
            else
            {
                MessageBox.Show("Porosia duhet te kete se paku nje produkt");
                this.Close();
            }
           
           
            
            //lstProduktetEPorosise.Items.Clear();
            
        }

        private void TabPannel()
        {
           
            //llojet.Add(llojetEProdukteveService.ListLlojetProdukteve());
            foreach (LlojetEProdukteve lloji in llojet)
            {
                tabControl1.TabPages.Add(lloji.ID.ToString(),lloji.Lloji);
            }
        }

        private void ProduktToTab()
        {
            foreach(TabPage tp in tabControl1.TabPages)
            {
                FlowLayoutPanel flp=new FlowLayoutPanel();
                flp.Dock= DockStyle.Fill;
                foreach(Produkti pr in produktet)
                {
                    Button b = new Button();
                    b.Size = new Size(100,100);
                    b.Text = pr.Emri;
                    b.Tag = pr;
                    b.Click += UpdateProductList;
                    if (pr.Lloji == tp.Text)
                    {
                        flp.Controls.Add(b);
                    }
                    
                }
                
                tp.Controls.Add(flp);
            }
        }

        private void UpdateProductList(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            Produkti p = (Produkti)b.Tag;
            if (p.Sasia>0)
            {
                produktetEporosise.Add(p);

                CmimiTotal += p.Cmimi;
            }
            else
            {
                MessageBox.Show("Nuk ka produkt ne stok");
            }
          
        }

        private void FormatListaProduktev(object sender, ListControlConvertEventArgs e)
        {
            string currentProdukt = ((Produkti)e.ListItem).Emri;
            string currentPrice= String.Format("{0:c}", ((Produkti)e.ListItem).Cmimi);
            string currentProduktPadded = currentProdukt.PadRight(30);
            e.Value= currentProduktPadded+currentPrice;
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            Produkti pr = (Produkti)lstProduktetEPorosise.SelectedItem;
            produktet.Remove(pr);
            CmimiTotal -= pr.Cmimi;
        }
        public void PopulloComboList()
        {
            cbTavolina.ValueMember = "ID";
            cbTavolina.DisplayMember = "ID";
            cbTavolina.DataSource=tavolinatServices.GetAll().Tables[0];
        }

        
    }


}
