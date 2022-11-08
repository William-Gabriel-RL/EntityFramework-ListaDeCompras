using ListaDeCompras.Data;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System;
using ListaDeCompras.Forms;

namespace ListaDeCompras
{
    public partial class FrmSupermercados : Form
    {
        public FrmSupermercados()
        {
            InitializeComponent();

            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from supermercado in context.Supermercados select supermercado).ToList();
            }
            ConfiguraGrade();
        }

        private void ConfiguraGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.RowHeadersWidth = 25;

            dataGridView1.Columns["Id"].HeaderText = "Id";
        }

        private void alterarToolStripButton_Click(object sender, System.EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            using (var frm = new FrmSupermercadoCadastro(id))
                frm.ShowDialog();
        }

        private void adicionarToolStripButton_Click(object sender, EventArgs e)
        {
            var id = 0;
            using (var frm = new FrmSupermercadoCadastro(id))
                frm.ShowDialog();
        }

        private void visualizarToolStripButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            using (var frm = new FrmSupermercadoCadastro(id, "v"))
                frm.ShowDialog();
        }

        private void excluirStripButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            using (var frm = new FrmSupermercadoCadastro(id, "e"))
                frm.ShowDialog();
        }
    }
}
