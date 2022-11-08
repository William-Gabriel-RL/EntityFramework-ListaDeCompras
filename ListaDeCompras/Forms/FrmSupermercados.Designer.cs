namespace ListaDeCompras
{
    partial class FrmSupermercados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupermercados));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.adicionarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.alterarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.visualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.excluirStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(698, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripButton,
            this.toolStripSeparator1,
            this.alterarToolStripButton,
            this.toolStripSeparator2,
            this.visualizarToolStripButton,
            this.toolStripSeparator3,
            this.excluirStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(779, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // adicionarToolStripButton
            // 
            this.adicionarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("adicionarToolStripButton.Image")));
            this.adicionarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adicionarToolStripButton.Name = "adicionarToolStripButton";
            this.adicionarToolStripButton.Size = new System.Drawing.Size(115, 29);
            this.adicionarToolStripButton.Text = "Adicionar";
            this.adicionarToolStripButton.Click += new System.EventHandler(this.adicionarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // alterarToolStripButton
            // 
            this.alterarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alterarToolStripButton.Image")));
            this.alterarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alterarToolStripButton.Name = "alterarToolStripButton";
            this.alterarToolStripButton.Size = new System.Drawing.Size(92, 29);
            this.alterarToolStripButton.Text = "Alterar";
            this.alterarToolStripButton.Click += new System.EventHandler(this.alterarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // visualizarToolStripButton
            // 
            this.visualizarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("visualizarToolStripButton.Image")));
            this.visualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.visualizarToolStripButton.Name = "visualizarToolStripButton";
            this.visualizarToolStripButton.Size = new System.Drawing.Size(113, 29);
            this.visualizarToolStripButton.Text = "Visualizar";
            this.visualizarToolStripButton.Click += new System.EventHandler(this.visualizarToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // excluirStripButton
            // 
            this.excluirStripButton.Image = ((System.Drawing.Image)(resources.GetObject("excluirStripButton.Image")));
            this.excluirStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluirStripButton.Name = "excluirStripButton";
            this.excluirStripButton.Size = new System.Drawing.Size(89, 29);
            this.excluirStripButton.Text = "Excluir";
            this.excluirStripButton.Click += new System.EventHandler(this.excluirStripButton_Click);
            // 
            // FrmSupermercados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 528);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSupermercados";
            this.Text = "Supermercados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton adicionarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton alterarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton visualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton excluirStripButton;
    }
}