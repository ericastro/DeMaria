namespace WindowsFormsCRUDPgSql
{
    partial class FormReceitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxKitSabor = new System.Windows.Forms.ComboBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblKitSabor = new System.Windows.Forms.Label();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tbxReceitasID = new System.Windows.Forms.TextBox();
            this.lbReceitasID = new System.Windows.Forms.Label();
            this.dgvReceita = new System.Windows.Forms.DataGridView();
            this.btnFecharReceita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceita)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxKitSabor
            // 
            this.cbxKitSabor.Enabled = false;
            this.cbxKitSabor.FormattingEnabled = true;
            this.cbxKitSabor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxKitSabor.Location = new System.Drawing.Point(383, 41);
            this.cbxKitSabor.Name = "cbxKitSabor";
            this.cbxKitSabor.Size = new System.Drawing.Size(309, 21);
            this.cbxKitSabor.TabIndex = 22;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(698, 38);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 16;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(34, 127);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(318, 23);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar e Incluir Kits Sabores";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(196, 253);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(115, 253);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(34, 253);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblKitSabor
            // 
            this.lblKitSabor.AutoSize = true;
            this.lblKitSabor.Location = new System.Drawing.Point(380, 25);
            this.lblKitSabor.Name = "lblKitSabor";
            this.lblKitSabor.Size = new System.Drawing.Size(50, 13);
            this.lblKitSabor.TabIndex = 18;
            this.lblKitSabor.Text = "Kit Sabor";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(34, 91);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(318, 20);
            this.tbxDescricao.TabIndex = 14;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(31, 75);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(90, 13);
            this.lblDescricao.TabIndex = 15;
            this.lblDescricao.Text = "Nome da Receita";
            // 
            // tbxReceitasID
            // 
            this.tbxReceitasID.Enabled = false;
            this.tbxReceitasID.Location = new System.Drawing.Point(34, 41);
            this.tbxReceitasID.Name = "tbxReceitasID";
            this.tbxReceitasID.Size = new System.Drawing.Size(100, 20);
            this.tbxReceitasID.TabIndex = 13;
            // 
            // lbReceitasID
            // 
            this.lbReceitasID.AutoSize = true;
            this.lbReceitasID.Location = new System.Drawing.Point(31, 25);
            this.lbReceitasID.Name = "lbReceitasID";
            this.lbReceitasID.Size = new System.Drawing.Size(40, 13);
            this.lbReceitasID.TabIndex = 12;
            this.lbReceitasID.Text = "Código";
            // 
            // dgvReceita
            // 
            this.dgvReceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceita.Location = new System.Drawing.Point(383, 75);
            this.dgvReceita.Name = "dgvReceita";
            this.dgvReceita.Size = new System.Drawing.Size(390, 155);
            this.dgvReceita.TabIndex = 23;
            // 
            // btnFecharReceita
            // 
            this.btnFecharReceita.Location = new System.Drawing.Point(383, 253);
            this.btnFecharReceita.Name = "btnFecharReceita";
            this.btnFecharReceita.Size = new System.Drawing.Size(390, 23);
            this.btnFecharReceita.TabIndex = 24;
            this.btnFecharReceita.Text = "Fechar Receita";
            this.btnFecharReceita.UseVisualStyleBackColor = true;
            this.btnFecharReceita.Click += new System.EventHandler(this.btnFecharReceita_Click);
            // 
            // FormReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 288);
            this.Controls.Add(this.btnFecharReceita);
            this.Controls.Add(this.dgvReceita);
            this.Controls.Add(this.cbxKitSabor);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblKitSabor);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.tbxReceitasID);
            this.Controls.Add(this.lbReceitasID);
            this.Name = "FormReceitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Receitas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxKitSabor;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblKitSabor;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tbxReceitasID;
        private System.Windows.Forms.Label lbReceitasID;
        private System.Windows.Forms.DataGridView dgvReceita;
        private System.Windows.Forms.Button btnFecharReceita;
    }
}