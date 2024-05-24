﻿using Project_Pim.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pim.Apresentacao
{
    public partial class FrmQuestionario3 : Form
    {
        public FrmQuestionario3()
        {
            InitializeComponent();
            pgbPontuacao.Maximum = 5;
            // Atribui o valor à propriedade Value da ProgressBar
            pgbPontuacao.Value = Estatico.Valor;
        }

        private void btnNao1_Click(object sender, EventArgs e)
        {
            btnNao1.BackColor = Color.Red;
            btnNao1.Enabled = false;
            btnSim1.Enabled = false;
        }

        private void btnSim1_Click(object sender, EventArgs e)
        {
            Estatico.Valor++;
            lblPontuacao.Text = "Pontuação:  0" + Estatico.Valor;
            pgbPontuacao.Value = Estatico.Valor;
            btnNao1.Enabled = false;
            btnSim1.Enabled = false;
            btnSim1.BackColor = Color.Green;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            FrmQuestionario4 frmQuestionario4 = new FrmQuestionario4();
            frmQuestionario4.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Visible = true;
            this.Close();
            Estatico.Valor = 0;
            pgbPontuacao.Value = 0;
        }

        private void FrmQuestionario3_Load(object sender, EventArgs e)
        {
            lblPontuacao.Text = "Pontuação:  0" + Estatico.Valor;
        }
    }
}