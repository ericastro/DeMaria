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
    public partial class FormKitSabor : Form
    {
        public FormKitSabor()
        {
            InitializeComponent();
            tbxKitSaborID.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDescricao.Text))
            {
                MessageBox.Show("Não é possivel incluir um Kit Sabor sem sua descrição!");
                tbxDescricao.Focus();
                return;
            }

            KitSabor kitSabor = new KitSabor();
            kitSabor.Descricao = tbxDescricao.Text;

            string result = kitSabor.InserirKitSabor(kitSabor);

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
        }

        private void DesabilitarCampos()
        {
            tbxDescricao.Enabled = false;
        }

        private void LimparTextBoxes()
        {
            tbxDescricao.Text = string.Empty;
            tbxKitSaborID.Text = string.Empty;
        }

        private void IncluirPesquisarMostraBotoes()
        {
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnIncluir.Visible = true;
            btnPesquisar.Visible = true;
            btnSalvar.Visible = false;
        }
    }
}
