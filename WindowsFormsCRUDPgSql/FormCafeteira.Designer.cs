namespace WindowsFormsCRUDPgSql
{
    partial class FormCafeteira
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
            this.lblCapsulas = new System.Windows.Forms.Label();
            this.cbxKitSabor = new System.Windows.Forms.ComboBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.btnFazerCafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCapsulas
            // 
            this.lblCapsulas.AutoSize = true;
            this.lblCapsulas.Location = new System.Drawing.Point(21, 34);
            this.lblCapsulas.Name = "lblCapsulas";
            this.lblCapsulas.Size = new System.Drawing.Size(44, 13);
            this.lblCapsulas.TabIndex = 0;
            this.lblCapsulas.Text = "Receita";
            // 
            // cbxKitSabor
            // 
            this.cbxKitSabor.FormattingEnabled = true;
            this.cbxKitSabor.Location = new System.Drawing.Point(24, 50);
            this.cbxKitSabor.Name = "cbxKitSabor";
            this.cbxKitSabor.Size = new System.Drawing.Size(285, 21);
            this.cbxKitSabor.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(312, 34);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(117, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade de Xícaras";
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(315, 50);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(121, 20);
            this.tbxQuantidade.TabIndex = 3;
            // 
            // btnFazerCafe
            // 
            this.btnFazerCafe.Location = new System.Drawing.Point(442, 50);
            this.btnFazerCafe.Name = "btnFazerCafe";
            this.btnFazerCafe.Size = new System.Drawing.Size(127, 21);
            this.btnFazerCafe.TabIndex = 4;
            this.btnFazerCafe.Text = "Fazer o Café";
            this.btnFazerCafe.UseVisualStyleBackColor = true;
            this.btnFazerCafe.Click += new System.EventHandler(this.btnFazerCafe_Click);
            // 
            // FormCafeteira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 108);
            this.Controls.Add(this.btnFazerCafe);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.cbxKitSabor);
            this.Controls.Add(this.lblCapsulas);
            this.Name = "FormCafeteira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafeteira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapsulas;
        private System.Windows.Forms.ComboBox cbxKitSabor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.Button btnFazerCafe;
    }
}