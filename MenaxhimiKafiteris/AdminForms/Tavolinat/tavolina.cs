﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiKafiteris.AdminForms.Tavolinat
{
    public partial class tavolina : Form
    {
        public tavolina()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var formPopup = new shtoTavoline();
            formPopup.Show(this); // if you need non-modal window
        }
    }
}