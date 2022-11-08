namespace ListaDeCompras.Forms
{
    partial class FrmListaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxEstaAtiva = new System.Windows.Forms.CheckBox();
            this.textoUsuario = new System.Windows.Forms.TextBox();
            this.textoTotal = new System.Windows.Forms.TextBox();
            this.textoData = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuário";
            // 
            // checkBoxEstaAtiva
            // 
            this.checkBoxEstaAtiva.AutoSize = true;
            this.checkBoxEstaAtiva.Location = new System.Drawing.Point(170, 236);
            this.checkBoxEstaAtiva.Name = "checkBoxEstaAtiva";
            this.checkBoxEstaAtiva.Size = new System.Drawing.Size(70, 24);
            this.checkBoxEstaAtiva.TabIndex = 4;
            this.checkBoxEstaAtiva.Text = "Ativa";
            this.checkBoxEstaAtiva.UseVisualStyleBackColor = true;
            // 
            // textoUsuario
            // 
            this.textoUsuario.Location = new System.Drawing.Point(170, 84);
            this.textoUsuario.Name = "textoUsuario";
            this.textoUsuario.ReadOnly = true;
            this.textoUsuario.Size = new System.Drawing.Size(100, 26);
            this.textoUsuario.TabIndex = 5;
            // 
            // textoTotal
            // 
            this.textoTotal.Location = new System.Drawing.Point(170, 188);
            this.textoTotal.Name = "textoTotal";
            this.textoTotal.Size = new System.Drawing.Size(100, 26);
            this.textoTotal.TabIndex = 6;
            // 
            // textoData
            // 
            this.textoData.Location = new System.Drawing.Point(170, 134);
            this.textoData.Name = "textoData";
            this.textoData.Size = new System.Drawing.Size(100, 26);
            this.textoData.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripButton,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 34);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(87, 29);
            this.salvarToolStripButton.Text = "Salvar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // FrmListaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textoData);
            this.Controls.Add(this.textoTotal);
            this.Controls.Add(this.textoUsuario);
            this.Controls.Add(this.checkBoxEstaAtiva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmListaCadastro";
            this.Text = "FrmListaCadastro";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxEstaAtiva;
        private System.Windows.Forms.TextBox textoUsuario;
        private System.Windows.Forms.TextBox textoTotal;
        private System.Windows.Forms.TextBox textoData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}