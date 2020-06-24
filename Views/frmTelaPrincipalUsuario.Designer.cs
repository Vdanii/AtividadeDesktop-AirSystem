namespace AirSystem2.Views
{
    partial class frmTelaPrincipalUsuario
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
            this.btnLAviao = new System.Windows.Forms.Button();
            this.btnGAviao = new System.Windows.Forms.Button();
            this.btnGCompanhia = new System.Windows.Forms.Button();
            this.btnGRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLAviao
            // 
            this.btnLAviao.Location = new System.Drawing.Point(69, 48);
            this.btnLAviao.Name = "btnLAviao";
            this.btnLAviao.Size = new System.Drawing.Size(154, 96);
            this.btnLAviao.TabIndex = 0;
            this.btnLAviao.Text = "Listar Aviões";
            this.btnLAviao.UseVisualStyleBackColor = true;
            // 
            // btnGAviao
            // 
            this.btnGAviao.Location = new System.Drawing.Point(361, 48);
            this.btnGAviao.Name = "btnGAviao";
            this.btnGAviao.Size = new System.Drawing.Size(154, 96);
            this.btnGAviao.TabIndex = 1;
            this.btnGAviao.Text = "Gerenciar Avião";
            this.btnGAviao.UseVisualStyleBackColor = true;
            // 
            // btnGCompanhia
            // 
            this.btnGCompanhia.Location = new System.Drawing.Point(69, 221);
            this.btnGCompanhia.Name = "btnGCompanhia";
            this.btnGCompanhia.Size = new System.Drawing.Size(154, 96);
            this.btnGCompanhia.TabIndex = 2;
            this.btnGCompanhia.Text = "Gerenciar Companhia";
            this.btnGCompanhia.UseVisualStyleBackColor = true;
            // 
            // btnGRelatorios
            // 
            this.btnGRelatorios.Location = new System.Drawing.Point(361, 221);
            this.btnGRelatorios.Name = "btnGRelatorios";
            this.btnGRelatorios.Size = new System.Drawing.Size(154, 96);
            this.btnGRelatorios.TabIndex = 3;
            this.btnGRelatorios.Text = "Gerenciar Relatorios";
            this.btnGRelatorios.UseVisualStyleBackColor = true;
            // 
            // frmTelaPrincipalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 363);
            this.Controls.Add(this.btnGRelatorios);
            this.Controls.Add(this.btnGCompanhia);
            this.Controls.Add(this.btnGAviao);
            this.Controls.Add(this.btnLAviao);
            this.Name = "frmTelaPrincipalUsuario";
            this.Text = "frmTelaPrincipalUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLAviao;
        private System.Windows.Forms.Button btnGAviao;
        private System.Windows.Forms.Button btnGCompanhia;
        private System.Windows.Forms.Button btnGRelatorios;
    }
}