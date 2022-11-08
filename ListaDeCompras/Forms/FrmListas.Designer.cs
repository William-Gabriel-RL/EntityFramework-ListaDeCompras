namespace ListaDeCompras
{
    partial class FrmListas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.adicionarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.alterarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.visualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.excluirStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // adicionarToolStripButton
            // 
            this.adicionarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("adicionarToolStripButton.Image")));
            this.adicionarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adicionarToolStripButton.Name = "adicionarToolStripButton";
            this.adicionarToolStripButton.Size = new System.Drawing.Size(115, 29);
            this.adicionarToolStripButton.Text = "Adicionar";
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(776, 371);
            this.dataGridView1.TabIndex = 3;
            // 
            // FrmListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmListas";
            this.Text = "FrmListas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton adicionarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton alterarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton visualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton excluirStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}