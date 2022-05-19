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

namespace MenaxhimiKafiteris.AdminForms.Produktet
{
    public partial class shtoPerberesPerProdukt : Form
    {
        PerbersitServices perbersiservices;

        public shtoPerberesPerProdukt()
        {
            perbersiservices = new PerbersitServices();
            InitializeComponent();
            ShfaqPerbersit();
        }

        public void ShfaqPerbersit()
        {
            dgPerbersit.DataSource = perbersiservices.GetAll().Tables[0];
        }

    }
}
