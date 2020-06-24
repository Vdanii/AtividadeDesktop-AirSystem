namespace AirSystem2.Views
{
    partial class frmTelaPrincipalAdministrador
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
            this.btnListarUsu = new System.Windows.Forms.Button();
            this.btnListarA = new System.Windows.Forms.Button();
            this.btnGerenciarA = new System.Windows.Forms.Button();
            this.btnGerenciarC = new System.Windows.Forms.Button();
            this.btnGerenciarR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarUsu
            // 
            this.btnListarUsu.Location = new System.Drawing.Point(45, 37);
            this.btnListarUsu.Name = "btnListarUsu";
            this.btnListarUsu.Size = new System.Drawing.Size(160, 89);
            this.btnListarUsu.TabIndex = 0;
            this.btnListarUsu.Text = "Listar Usuarios";
            this.btnListarUsu.UseVisualStyleBackColor = true;
            this.btnListarUsu.Click += new System.EventHandler(this.btnListarUsu_Click);
            // 
            // btnListarA
            // 
            this.btnListarA.Location = new System.Drawing.Point(262, 37);
            this.btnListarA.Name = "btnListarA";
            this.btnListarA.Size = new System.Drawing.Size(160, 89);
            this.btnListarA.TabIndex = 1;
            this.btnListarA.Text = "Listar Aviões";
            this.btnListarA.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarA
            // 
            this.btnGerenciarA.Location = new System.Drawing.Point(484, 37);
            this.btnGerenciarA.Name = "btnGerenciarA";
            this.btnGerenciarA.Size = new System.Drawing.Size(160, 89);
            this.btnGerenciarA.TabIndex = 2;
            this.btnGerenciarA.Text = "Gerenciar Aviões";
            this.btnGerenciarA.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarC
            // 
            this.btnGerenciarC.Location = new System.Drawing.Point(138, 192);
            this.btnGerenciarC.Name = "btnGerenciarC";
            this.btnGerenciarC.Size = new System.Drawing.Size(160, 89);
            this.btnGerenciarC.TabIndex = 3;
            this.btnGerenciarC.Text = "Gerenciar Companhias";
            this.btnGerenciarC.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarR
            // 
            this.btnGerenciarR.Location = new System.Drawing.Point(388, 192);
            this.btnGerenciarR.Name = "btnGerenciarR";
            this.btnGerenciarR.Size = new System.Drawing.Size(160, 89);
            this.btnGerenciarR.TabIndex = 4;
            this.btnGerenciarR.Text = "Gerenciar Relatórios";
            this.btnGerenciarR.UseVisualStyleBackColor = true;
            // 
            // frmTelaPrincipalAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 357);
            this.Controls.Add(this.btnGerenciarR);
            this.Controls.Add(this.btnGerenciarC);
            this.Controls.Add(this.btnGerenciarA);
            this.Controls.Add(this.btnListarA);
            this.Controls.Add(this.btnListarUsu);
            this.Name = "frmTelaPrincipalAdministrador";
            this.Text = "frmTelaPrincipalAdministrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarUsu;
        private System.Windows.Forms.Button btnListarA;
        private System.Windows.Forms.Button btnGerenciarA;
        private System.Windows.Forms.Button btnGerenciarC;
        private System.Windows.Forms.Button btnGerenciarR;
    }
}