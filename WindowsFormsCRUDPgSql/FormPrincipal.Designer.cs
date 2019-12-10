namespace WindowsFormsCRUDPgSql
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capsulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitSaborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitItensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerCaféToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capsulasToolStripMenuItem,
            this.kitSaborToolStripMenuItem,
            this.kitItensToolStripMenuItem,
            this.receitasToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.fazerCaféToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.cadastrarToolStripMenuItem.Text = "Gerenciamento";
            // 
            // capsulasToolStripMenuItem
            // 
            this.capsulasToolStripMenuItem.Name = "capsulasToolStripMenuItem";
            this.capsulasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.capsulasToolStripMenuItem.Text = "Capsulas";
            this.capsulasToolStripMenuItem.Click += new System.EventHandler(this.capsulasToolStripMenuItem_Click);
            // 
            // kitSaborToolStripMenuItem
            // 
            this.kitSaborToolStripMenuItem.Name = "kitSaborToolStripMenuItem";
            this.kitSaborToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.kitSaborToolStripMenuItem.Text = "Kit Sabor";
            this.kitSaborToolStripMenuItem.Click += new System.EventHandler(this.kitSaborToolStripMenuItem_Click);
            // 
            // kitItensToolStripMenuItem
            // 
            this.kitItensToolStripMenuItem.Name = "kitItensToolStripMenuItem";
            this.kitItensToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.kitItensToolStripMenuItem.Text = "Kit Capsulas";
            this.kitItensToolStripMenuItem.Click += new System.EventHandler(this.kitItensToolStripMenuItem_Click);
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.receitasToolStripMenuItem.Text = "Receitas";
            this.receitasToolStripMenuItem.Click += new System.EventHandler(this.receitasToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // fazerCaféToolStripMenuItem
            // 
            this.fazerCaféToolStripMenuItem.Name = "fazerCaféToolStripMenuItem";
            this.fazerCaféToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fazerCaféToolStripMenuItem.Text = "Fazer Café";
            this.fazerCaféToolStripMenuItem.Click += new System.EventHandler(this.fazerCaféToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Capsulas de Café";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capsulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitSaborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitItensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerCaféToolStripMenuItem;
    }
}

