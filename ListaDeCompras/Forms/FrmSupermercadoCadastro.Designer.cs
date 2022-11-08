namespace ListaDeCompras.Forms
{
    partial class FrmSupermercadoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupermercadoCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textoCidade = new System.Windows.Forms.TextBox();
            this.textoBairro = new System.Windows.Forms.TextBox();
            this.textoLogradouro = new System.Windows.Forms.TextBox();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.textoEstado = new System.Windows.Forms.TextBox();
            this.textoCEP = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.excluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logradouro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "CEP";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(153, 44);
            this.textId.MaxLength = 7;
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(47, 26);
            this.textId.TabIndex = 7;
            // 
            // textoCidade
            // 
            this.textoCidade.Location = new System.Drawing.Point(153, 244);
            this.textoCidade.MaxLength = 70;
            this.textoCidade.Name = "textoCidade";
            this.textoCidade.Size = new System.Drawing.Size(208, 26);
            this.textoCidade.TabIndex = 8;
            // 
            // textoBairro
            // 
            this.textoBairro.Location = new System.Drawing.Point(153, 193);
            this.textoBairro.MaxLength = 70;
            this.textoBairro.Name = "textoBairro";
            this.textoBairro.Size = new System.Drawing.Size(208, 26);
            this.textoBairro.TabIndex = 9;
            // 
            // textoLogradouro
            // 
            this.textoLogradouro.Location = new System.Drawing.Point(153, 141);
            this.textoLogradouro.MaxLength = 70;
            this.textoLogradouro.Name = "textoLogradouro";
            this.textoLogradouro.Size = new System.Drawing.Size(208, 26);
            this.textoLogradouro.TabIndex = 10;
            // 
            // textoNome
            // 
            this.textoNome.Location = new System.Drawing.Point(153, 87);
            this.textoNome.MaxLength = 70;
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(208, 26);
            this.textoNome.TabIndex = 11;
            // 
            // textoEstado
            // 
            this.textoEstado.Location = new System.Drawing.Point(153, 298);
            this.textoEstado.MaxLength = 20;
            this.textoEstado.Name = "textoEstado";
            this.textoEstado.Size = new System.Drawing.Size(208, 26);
            this.textoEstado.TabIndex = 12;
            // 
            // textoCEP
            // 
            this.textoCEP.Location = new System.Drawing.Point(153, 360);
            this.textoCEP.MaxLength = 10;
            this.textoCEP.Name = "textoCEP";
            this.textoCEP.Size = new System.Drawing.Size(127, 26);
            this.textoCEP.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripButton,
            this.toolStripSeparator1,
            this.excluirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 34);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(87, 29);
            this.salvarToolStripButton.Text = "Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // excluirToolStripButton
            // 
            this.excluirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripButton.Image")));
            this.excluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluirToolStripButton.Name = "excluirToolStripButton";
            this.excluirToolStripButton.Size = new System.Drawing.Size(89, 29);
            this.excluirToolStripButton.Text = "Excluir";
            this.excluirToolStripButton.Visible = false;
            this.excluirToolStripButton.Click += new System.EventHandler(this.excluirToolStripButton_Click);
            // 
            // FrmSupermercadoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textoCEP);
            this.Controls.Add(this.textoEstado);
            this.Controls.Add(this.textoNome);
            this.Controls.Add(this.textoLogradouro);
            this.Controls.Add(this.textoBairro);
            this.Controls.Add(this.textoCidade);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSupermercadoCadastro";
            this.Text = "Cadastro de Supermercado";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textoCidade;
        private System.Windows.Forms.TextBox textoBairro;
        private System.Windows.Forms.TextBox textoLogradouro;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.TextBox textoEstado;
        private System.Windows.Forms.TextBox textoCEP;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton excluirToolStripButton;
    }
}