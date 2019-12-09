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
            Receitas receita = new Receitas();
            receita.Descricao = tbxDescricao.Text;

            receita.InserirReceitas(receita);

            tbxReceitasID.Text = receita.LastInsertID.ToString();

            tbxDescricao.Enabled = false;
            btnIncluir.Enabled = false;
            cbxKitSabor.Enabled = true;

            dt.Columns.Add("Id");
            dt.Columns.Add("KitSabor");
            dgvReceita.DataSource = dt;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }


        private void btnFecharReceita_Click(object sender, EventArgs e)
        {

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
