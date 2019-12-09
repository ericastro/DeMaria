namespace WindowsFormsCRUDPgSql
{
    partial class FormKitCapsulas
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
            this.components = new System.ComponentModel.Container();
            this.cbxKitSabor = new System.Windows.Forms.ComboBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lblKitSabor = new System.Windows.Forms.Label();
            this.dgvKitCapsulas = new System.Windows.Forms.DataGridView();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cbxTipoDeCapsulas = new System.Windows.Forms.ComboBox();
            this.lblTipoCapsulas = new System.Windows.Forms.Label();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitCapsulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxKitSabor
            // 
            this.cbxKitSabor.FormattingEnabled = true;
            this.cbxKitSabor.Location = new System.Drawing.Point(27, 40);
            this.cbxKitSabor.Name = "cbxKitSabor";
            this.cbxKitSabor.Size = new System.Drawing.Size(300, 21);
            this.cbxKitSabor.TabIndex = 18;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(252, 171);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lblKitSabor
            // 
            this.lblKitSabor.AutoSize = true;
            this.lblKitSabor.Location = new System.Drawing.Point(24, 24);
            this.lblKitSabor.Name = "lblKitSabor";
            this.lblKitSabor.Size = new System.Drawing.Size(50, 13);
            this.lblKitSabor.TabIndex = 14;
            this.lblKitSabor.Text = "Kit Sabor";
            // 
            // dgvKitCapsulas
            // 
            this.dgvKitCapsulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitCapsulas.Location = new System.Drawing.Point(356, 24);
            this.dgvKitCapsulas.Name = "dgvKitCapsulas";
            this.dgvKitCapsulas.Size = new System.Drawing.Size(413, 166);
            this.dgvKitCapsulas.TabIndex = 19;
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(27, 171);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(206, 20);
            this.tbxQuantidade.TabIndex = 25;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(24, 155);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 24;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // cbxTipoDeCapsulas
            // 
            this.cbxTipoDeCapsulas.FormattingEnabled = true;
            this.cbxTipoDeCapsulas.Items.AddRange(new object[] {
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
            this.cbxTipoDeCapsulas.Location = new System.Drawing.Point(27, 104);
            this.cbxTipoDeCapsulas.Name = "cbxTipoDeCapsulas";
            this.cbxTipoDeCapsulas.Size = new System.Drawing.Size(300, 21);
            this.cbxTipoDeCapsulas.TabIndex = 23;
            // 
            // lblTipoCapsulas
            // 
            this.lblTipoCapsulas.AutoSize = true;
            this.lblTipoCapsulas.Location = new System.Drawing.Point(24, 88);
            this.lblTipoCapsulas.Name = "lblTipoCapsulas";
            this.lblTipoCapsulas.Size = new System.Drawing.Size(74, 13);
            this.lblTipoCapsulas.TabIndex = 22;
            this.lblTipoCapsulas.Text = "Tipo Cápsulas";
            // 
            // FormKitCapsulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 213);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.cbxTipoDeCapsulas);
            this.Controls.Add(this.lblTipoCapsulas);
            this.Controls.Add(this.dgvKitCapsulas);
            this.Controls.Add(this.cbxKitSabor);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lblKitSabor);
            this.Name = "FormKitCapsulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Kit de Capsulas";
            this.Shown += new System.EventHandler(this.FormKitCapsulas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitCapsulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxKitSabor;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lblKitSabor;
        private System.Windows.Forms.DataGridView dgvKitCapsulas;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cbxTipoDeCapsulas;
        private System.Windows.Forms.Label lblTipoCapsulas;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
    }
}