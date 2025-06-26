﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class frmConta : Form
    {
        public frmConta()
        {
            InitializeComponent();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Instanciar a classe Conta
        Conta conta = new Conta();
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            conta.Valor = Convert.ToDouble(txtValor.Text);
            double[] saldo = new double[10];

            for (int i = 0; i < saldo.Length; i++)
            {
                saldo[i] = conta.depositar(conta.Valor);
            }
            for (int i = 0; i < saldo.Length; i++)
            {
                ltbExtrato.Items.Add("R$ " + saldo[i]);
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Poupanca poupanca = new Poupanca();
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                double valor, porc, resp;

                valor = Convert.ToDouble(txtValor.Text);
                porc = Convert.ToDouble(txtPorcentagem.Text);

                Poupanca cp = new Poupanca();
                resp = cp.calculoRendimento(porc, valor);

                ltbExtrato.Items.Add("Valor a receber: " + resp);

            }
            if (rdbContaCorrente.Checked)
            {
                ltbExtrato.Items.Add("Valor conta corrente: " + txtValor.Text);
            }
        }
    }
}
 
