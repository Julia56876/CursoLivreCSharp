using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class frmGerenciaFuncionarios : Form
    {
        public frmGerenciaFuncionarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtCidade.Enabled = false;
            txtEndereco.Enabled = false;
            txtComplemento.Enabled = false;
            txtNumero.Enabled = false;
            cbbEstado.Enabled = false;

            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            mskTelefone.Enabled = false;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;
        }
        public void habilitarCamposNovo()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtCidade.Enabled = true;
            txtEndereco.Enabled = true;
            txtComplemento.Enabled = true;
            txtNumero.Enabled = true;
            cbbEstado.Enabled = true;

            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            mskTelefone.Enabled = true;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;

            txtNome.Focus();
        }

        public void habilitarCamposPesquisar()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtCidade.Enabled = true;
            txtEndereco.Enabled = true;
            txtComplemento.Enabled = true;
            txtNumero.Enabled = true;
            cbbEstado.Enabled = true;

            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            mskTelefone.Enabled = true;

            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = false;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;

            txtNome.Focus();
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCidade.Clear();
            txtEndereco.Clear();
            txtComplemento.Clear();
            txtNumero.Clear();
            cbbEstado.Text = "";

            mskCEP.Text = "";
            mskCPF.Text = "";
            mskTelefone.Text = "";

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnVoltar.Enabled = true;

            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") ||
                txtEmail.Text.Equals("") ||
                txtEndereco.Text.Equals("") ||
                txtNumero.Text.Equals("") ||
                txtCidade.Text.Equals("") ||
                txtComplemento.Text.Equals("") ||
                cbbEstado.Text.Equals("") ||
                mskTelefone.Text.Equals("(  )      -") ||
                mskCPF.Text.Equals("   .   .   -") ||
                mskCEP.Text.Equals("     -")
         )
            {
                MessageBox.Show("Favor preencher os campos!");
            }
            else
            {
                MessageBox.Show("Cadastrado com Sucesso!");
                desabilitarCampos();
                LimparCampos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNome.Focus();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            habilitarCamposPesquisar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja Excluir?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Excluído com Suceso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                desabilitarCampos();
                LimparCampos();
            }
            else
            {
                txtNome.Focus();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alterado com Sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            desabilitarCampos();
            LimparCampos();        
        }
    }
}
