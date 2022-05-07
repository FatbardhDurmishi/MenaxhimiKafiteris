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
            Produkti newProdukt=new Produkti();
            newProdukt.Emri = txtEmri.Text;
            newProdukt.Cmimi = decimal.Parse(txtCmimi.Text);
            newProdukt.Sasia = int.Parse(txtSasia.Text);
            newProdukt.LlojiID = int.Parse(cbLloji.SelectedValue.ToString());
            bool isSaved=produktetServices.ShtoProdukt(newProdukt);
        }
        private void PopulloComboList()
        {
            cbLloji.DisplayMember = "Name";
            cbLloji.ValueMember = "Id";
            cbLloji.DataSource = llojetEProdukteveService.GetAll().Tables[0];
        }
    }
}
