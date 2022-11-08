namespace ListaDeCompras
{
    partial class FrmMenu
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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnSupermercados = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(35, 22);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(129, 64);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSupermercados
            // 
            this.btnSupermercados.Location = new System.Drawing.Point(35, 103);
            this.btnSupermercados.Name = "btnSupermercados";
            this.btnSupermercados.Size = new System.Drawing.Size(158, 66);
            this.btnSupermercados.TabIndex = 1;
            this.btnSupermercados.Text = "Supermercados";
            this.btnSupermercados.UseVisualStyleBackColor = true;
            this.btnSupermercados.Click += new System.EventHandler(this.btnSupermercados_Click);
            // 
            // btnListas
            // 
            this.btnListas.Location = new System.Drawing.Point(35, 192);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(158, 59);
            this.btnListas.TabIndex = 2;
            this.btnListas.Text = "Listas";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 278);
            this.Controls.Add(this.btnListas);
            this.Controls.Add(this.btnSupermercados);
            this.Controls.Add(this.btnUsuarios);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSupermercados;
        private System.Windows.Forms.Button btnListas;
    }
}