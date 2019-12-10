using Npgsql;
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
            dt.Columns.Add("Id");
            dt.Columns.Add("KitSabor");
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
            if(string.IsNullOrEmpty(tbxDescricao.Text))
            {
                MessageBox.Show("É preciso dar uma descrição para a receita!");
                return;
            }

            Receitas receita = new Receitas();
            receita.Descricao = tbxDescricao.Text;
            receita.InserirReceitas(receita);

            tbxReceitasID.Text = receita.LastInsertID.ToString();

            btnSalvar.Visible = false;
            tbxDescricao.Enabled = false;
            btnIncluir.Enabled = true;
            cbxKitSabor.Enabled = true;
            dgvReceita.DataSource = dt;
            dgvReceita.Visible = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }


        private void btnFecharReceita_Click(object sender, EventArgs e)
        {
            btnIncluir.Enabled = false;
            btnIncluir.Visible = false;
            cbxKitSabor.Enabled = false;
            cbxKitSabor.Visible = false;
            btnFecharReceita.Visible = false;
            dgvReceita.Visible = false;
            lblKitSabor.Visible = false;

            tbxReceitasID.Text = string.Empty;
            tbxDescricao.Text = string.Empty;
            tbxDescricao.Enabled = true;
            btnSalvar.Enabled = true;
            btnSalvar.Visible = true;

            dgvReceita.DataSource = dt;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ReceitaItem receitaItem = new ReceitaItem();
            receitaItem.ReceitaID = Convert.ToUInt16(tbxReceitasID.Text);
            receitaItem.KitSaborID = cbxKitSabor.SelectedIndex;
            receitaItem.IncluirItensDaReceita(receitaItem);

            string result = receitaItem.IncluirItensDaReceita(receitaItem);

            if (result != "ok")
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Kit Sabor incluido na receita com sucesso!");

                DataRow row = dt.NewRow();
                row["Id"] = cbxKitSabor.SelectedIndex.ToString();
                row["KitSabor"] = cbxKitSabor.Text.ToString();
                dt.Rows.Add(row);
                dgvReceita.DataSource = dt;
                dgvReceita.Refresh();

                //LimparTextBoxes();
                //IncluirPesquisarMostraBotoes();
                //DesabilitarCampos();
            };

        }
    }
}
