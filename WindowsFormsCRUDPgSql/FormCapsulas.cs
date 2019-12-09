using System;
using System.Windows.Forms;

namespace WindowsFormsCRUDPgSql
{
    public partial class FormCapsulas : Form
    {
        public FormCapsulas()
        {
            InitializeComponent();
            tbxCapsulasID.Enabled = false;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            IncluirEditarOcultarBotoes();
        }

        private void IncluirEditarOcultarBotoes()
        {
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnIncluir.Visible = false;
            btnPesquisar.Visible = false;
            btnSalvar.Visible = true;

            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            tbxDescricao.Enabled = true;
            cbxForca.Enabled = true;
            cbxForca.SelectedIndex = 0;
        }

        private void DesabilitarCampos()
        {
            tbxDescricao.Enabled = false;
            cbxForca.Enabled = false;
            cbxForca.SelectedIndex = 0;
        }

        private void IncluirPesquisarMostraBotoes()
        {
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnIncluir.Visible = true;
            btnPesquisar.Visible = true;
            btnSalvar.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDescricao.Text))
            {
                MessageBox.Show("Não é possivel incluir uma capsula sem sua descrição!");
                tbxDescricao.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(cbxForca.Text))
                {
                    MessageBox.Show("Não é possivel incluir uma capsula sem selecionar o campo força!");
                    cbxForca.Focus();
                    return;
                }
            }

            CapsulasDeCafe capsula = new CapsulasDeCafe();
            capsula.Descricao = tbxDescricao.Text;
            capsula.Forca = Convert.ToInt16(cbxForca.Text);

            string result = capsula.InserirCapuslaDeCafe(capsula);

            if (result != "ok")
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Capsula Cadastrada com sucesso!");
                LimparTextBoxes();
                IncluirPesquisarMostraBotoes();
                DesabilitarCampos();
            };
        }

        private void LimparTextBoxes()
        {
            tbxCapsulasID.Text = "";
            tbxDescricao.Text = "";
            cbxForca.SelectedItem = 1;
        }
    }
}
