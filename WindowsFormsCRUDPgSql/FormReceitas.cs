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
    public partial class FormReceitas : Form
    {
        public DataTable dt = new DataTable();

        public FormReceitas()
        {
            InitializeComponent();
            PreencheCbxKitSabor();
        }

        private void PreencheCbxKitSabor()
        {
            KitSabor kitSabor = new KitSabor();
            DataTable dtKitSabor = kitSabor.ListarKitSabor();
            cbxKitSabor.DataSource = dtKitSabor;
            cbxKitSabor.DisplayMember = "Descricao";
            cbxKitSabor.ValueMember = "KitSaborID";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDescricao.Text))
            {
                MessageBox.Show("Não é possivel salvar uma receita sem um nome");
                tbxDescricao.Focus();
                return;
            }

            cbxKitSabor.Enabled = true;

            Receitas receita = new Receitas();
            receita.Descricao = tbxDescricao.Text;

            dt.Columns.Add("Id");
            dt.Columns.Add("KitSabor");
            dgvReceita.DataSource = dt;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }


        private void btnFecharReceita_Click(object sender, EventArgs e)
        {
            string texto = cbxKitSabor.GetItemText(cbxKitSabor.SelectedItem);
            int text = cbxKitSabor.Items.IndexOf(cbxKitSabor.GetItemText(cbxKitSabor.SelectedItem));
            MessageBox.Show(text.ToString());

            /*
            receita.ListaKitSaborID = 

            KitCapsulas kitCapsulas = new KitCapsulas();
            kitCapsulas.KitSaborID = Convert.ToInt16(cbxKitSabor.SelectedValue);
            kitCapsulas.KitCapsulaID = Convert.ToInt16(cbxTipoDeCapsulas.SelectedValue);
            kitCapsulas.Quantidade = Convert.ToInt16(tbxQuantidade.Text);


            string result = kitCapsulas.InserirCapuslaDeCafe(kitCapsulas);

            if (result != "ok")
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Capsula Cadastrada com sucesso!");
                PreencheDataGrid();
                //LimparTextBoxes();
                //IncluirPesquisarMostraBotoes();
                //DesabilitarCampos();
            };
            */
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            row["Id"] = cbxKitSabor.SelectedIndex.ToString();
            row["KitSabor"] = cbxKitSabor.Text.ToString();
            dt.Rows.Add(row);
            dgvReceita.DataSource = dt;
            dgvReceita.Refresh();
        }
    }
}
