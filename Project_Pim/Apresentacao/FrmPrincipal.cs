﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pim
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pcbMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            frmMenu.Show();
            
            this.Visible = false;
        }
    }
}
