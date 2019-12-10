namespace WindowsFormsCRUDPgSql
{
    partial class FormControleDeEstoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCapsulaID = new System.Windows.Forms.TextBox();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblValidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbxCapsulas = new System.Windows.Forms.ComboBox();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Códido da Capsula";
            // 
            // tbxCapsulaID
            // 
            this.tbxCapsulaID.Enabled = false;
            this.tbxCapsulaID.Location = new System.Drawing.Point(35, 47);
            this.tbxCapsulaID.Name = "tbxCapsulaID";
            this.tbxCapsulaID.Size = new System.Drawing.Size(100, 20);
            this.tbxCapsulaID.TabIndex = 1;
            // 
            // dtpValidade
            // 
            this.dtpValidade.Enabled = false;
            this.dtpValidade.Location = new System.Drawing.Point(35, 211);
            this.dtpValidade.MinDate = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(210, 20);
            this.dtpValidade.TabIndex = 18;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(29, 365);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 13;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(272, 324);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(272, 365);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(191, 365);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(110, 365);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(32, 192);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(48, 13);
            this.lblValidade.TabIndex = 19;
            this.lblValidade.Text = "Validade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data de Entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Enabled = false;
            this.dtpDataEntrada.Location = new System.Drawing.Point(35, 269);
            this.dtpDataEntrada.MinDate = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(210, 20);
            this.dtpDataEntrada.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data de Saída";
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Enabled = false;
            this.dtpDataSaida.Location = new System.Drawing.Point(35, 324);
            this.dtpDataSaida.MinDate = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(210, 20);
            this.dtpDataSaida.TabIndex = 22;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(32, 81);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 25;
            this.lblDescricao.Text = "Descrição";
            // 
            // cbxCapsulas
            // 
            this.cbxCapsulas.Enabled = false;
            this.cbxCapsulas.FormattingEnabled = true;
            this.cbxCapsulas.Location = new System.Drawing.Point(35, 97);
            this.cbxCapsulas.Name = "cbxCapsulas";
            this.cbxCapsulas.Size = new System.Drawing.Size(210, 21);
            this.cbxCapsulas.TabIndex = 26;
            this.cbxCapsulas.SelectedIndexChanged += new System.EventHandler(this.cbxCapsulas_SelectedIndexChanged);
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Enabled = false;
            this.tbxQuantidade.Location = new System.Drawing.Point(35, 150);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(210, 20);
            this.tbxQuantidade.TabIndex = 27;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(31, 134);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 28;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // FormControleDeEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 418);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.cbxCapsulas);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.dtpValidade);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbxCapsulaID);
            this.Controls.Add(this.label1);
            this.Name = "FormControleDeEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque de Capsulas";
            this.Load += new System.EventHandler(this.FormControleDeEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCapsulaID;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cbxCapsulas;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
    }
}