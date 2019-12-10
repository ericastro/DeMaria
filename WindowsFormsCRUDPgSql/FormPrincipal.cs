using System;
using System.Windows.Forms;
using System.Data;
using Npgsql;


namespace WindowsFormsCRUDPgSql
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            try
            {
                    ConnetionPostgres connectionPostgres = new ConnetionPostgres();
                    NpgsqlConnection conn = new NpgsqlConnection(connectionPostgres.ConnString);
                    string sql = "SELECT * FROM public.\"Capsulas\"";
                    NpgsqlCommand cmd;
                    conn.Open();
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
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

        private void capsulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCapsulas form = new FormCapsulas();
            form.Show();
        }

        private void kitSaborToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKitSabor form = new FormKitSabor();
            form.Show();
        }

        private void kitItensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKitCapsulas form = new FormKitCapsulas();
            form.Show();
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReceitas form = new FormReceitas();
            form.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControleDeEstoque form = new FormControleDeEstoque();
            form.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fazerCaféToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCafeteira form = new FormCafeteira();
            form.Show();
        }
    }
}
