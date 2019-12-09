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
    public partial class FormKitCapsulas : Form
    {
        public FormKitCapsulas()
        {
            InitializeComponent();

            KitSabor kitSabor = new KitSabor();
            DataTable dtKitSabor = kitSabor.ListarKitSabor();
            cbxKitSabor.DataSource = dtKitSabor;
            cbxKitSabor.DisplayMember = "Descricao";
            cbxKitSabor.ValueMember = "KitSaborID";

            CapsulasDeCafe capsulas = new CapsulasDeCafe();
            DataTable dtCapsulas = capsulas.ListarCapsulas();
            cbxTipoDeCapsulas.DataSource = dtCapsulas;
            cbxTipoDeCapsulas.DisplayMember = "Descricao";
            cbxTipoDeCapsulas.ValueMember = "CapsulasID";

            KitCapsulas kitCapsulas = new KitCapsulas();
            DataTable dtKitCapsulas = kitCapsulas.ListarKitCapsulas();
            dgvKitCapsulas.DataSource = dtKitCapsulas;

        }

        private void FormKitCapsulas_Shown(object sender, EventArgs e)
        {
            PreencheDataGrid();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxQuantidade.Text))
            {
                MessageBox.Show("Não é possivel incluir KIT sem uma quantidade de Capsulas");
                tbxQuantidade.Focus();
                return;
            }
           
            
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
        }

        private void PreencheDataGrid()
        {
            ConnetionPostgres connectionPostgres = new ConnetionPostgres();
            NpgsqlConnection conn = new NpgsqlConnection(connectionPostgres.ConnString);

            string sql = "SELECT * FROM public.\"KitCapsulas\"";
            NpgsqlCommand cmd;
            DataTable dt;

            try
            {
                conn.Open();
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvKitCapsulas.DataSource = dt;
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não conseguimos conectar ao servidor, por favor verifique os parametros de configuração!");
                FormConnectionConfig form = new FormConnectionConfig();
                form.Show();
                form.Activate();
            }
        }
    }
}
