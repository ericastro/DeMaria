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
    public partial class FormCafeteira : Form
    {
        public DataTable dtCapsulas;

        public FormCafeteira()
        {
            InitializeComponent();
            CapsulasDeCafe capsula = new CapsulasDeCafe();
            dtCapsulas = capsula.ListarCapsulas();
            cbxKitSabor.DataSource = dtCapsulas;
            cbxKitSabor.DisplayMember = "Descrição";
            cbxKitSabor.ValueMember = "capsulasID";

        }

        private void btnFazerCafe_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbxQuantidade.Text))
            {
                MessageBox.Show("Digite a quantidade de xícaras desejadas");
                return;
            }

            int quantidade = Convert.ToInt32(tbxQuantidade.Text);
            int capsulaID = cbxKitSabor.SelectedIndex;
            Estoque estoque = new Estoque();

            if (estoque.VerificarEstoqueDeCapsulas(capsulaID, quantidade))
            {
                FazerCafes();
            }
            else
            {
                MessageBox.Show("Não existem cápsulas suficientes para Fazer os cafés!");
            }
        }

        private void FazerCafes()
        {
            MessageBox.Show("Pronto você já pode saborear seu café!");
            Estoque ert = new Estoque();
        }


    }
}
