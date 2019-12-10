using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCRUDPgSql
{
    public partial class FormControleDeEstoque : Form
    {
        public FormControleDeEstoque()
        {
            InitializeComponent();
            dtpValidade.MinDate = DateTime.Now;
            dtpDataEntrada.MinDate = DateTime.Now;
            dtpDataSaida.MinDate = DateTime.Now;

            CapsulasDeCafe capsulas = new CapsulasDeCafe();
            DataTable dtCapsulas = capsulas.ListarCapsulas();
            cbxCapsulas.DataSource = dtCapsulas;
            cbxCapsulas.DisplayMember = "Descricao";
            cbxCapsulas.ValueMember = "capsulasID";

            tbxCapsulaID.Text = cbxCapsulas.SelectedIndex.ToString();
        }

        private void FormControleDeEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dtpDataEntrada.Enabled = true;
            dtpDataSaida.Enabled = true;
            dtpValidade.Enabled = true;

            btnSalvar.Enabled = true;
            btnSalvar.Visible = true;
            btnPesquisar.Visible = false;
            btnIncluir.Enabled = false;

            tbxQuantidade.Enabled = true;
            cbxCapsulas.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxQuantidade.Text))
            {
                MessageBox.Show("Digite uma quantidade de Capsulas para ser cadastrada!");
                tbxQuantidade.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(cbxCapsulas.Text))
                {
                    MessageBox.Show("Escolha um tipo de Capsula para ser cadastrado!");
                    cbxCapsulas.Focus();
                    return;
                }
            }

            CapsulasDeCafe capsula = new CapsulasDeCafe();
            capsula.CapsulasID = cbxCapsulas.SelectedIndex;

            Estoque estoque = new Estoque();
            estoque.CapsulasID = capsula.CapsulasID;
            estoque.DataEntrada = Convert.ToDateTime(dtpDataEntrada.Text);
            estoque.Validade = Convert.ToDateTime(dtpValidade.Text);
            estoque.Quantidade = Convert.ToInt32(tbxQuantidade.Text);
            estoque.DataSaida = Convert.ToDateTime(dtpDataSaida.Text);

            string result = estoque.IncluirCapsulasNoEstoque(estoque);

            if (result != "ok")
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Capsula Cadastrada com sucesso!");
                //LimparTextBoxes();
                //IncluirPesquisarMostraBotoes();
                //DesabilitarCampos();
            };
        }

        private void cbxCapsulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxCapsulaID.Text = cbxCapsulas.SelectedIndex.ToString();
        }
    }
}
