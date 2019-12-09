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
    public partial class FormConnectionConfig : Form
    {
        public FormConnectionConfig()
        {
            InitializeComponent();
        }

        private void FormConnectionConfig_Shown(object sender, EventArgs e)
        {
            ConnetionPostgres conn = new ConnetionPostgres();
            textBox1.Text = conn.ServerName;
            textBox2.Text = conn.Port;
            textBox3.Text = conn.UserName;
            textBox4.Text = conn.Password;
        }
    }
}
