using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiKafiteris.UserForms
{
    public partial class PaguajPorosin : Form
    {
        decimal totali;
        decimal ParateGatshme;
        public PaguajPorosin()
        {
            InitializeComponent();
            totali = mainKamarier.Totali;
            txtTotali.Text = totali.ToString();


        }

        private void btnPaguaj_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void btnLlogarit_Click(object sender, EventArgs e)
        {
            ParateGatshme = decimal.Parse(txtParatgatshme.Text);
            txtKusuri.Text = (ParateGatshme - totali).ToString();
        }
    }
}
