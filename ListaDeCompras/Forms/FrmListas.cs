using ListaDeCompras.Data;
using ListaDeCompras.Forms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class FrmListas : Form
    {
        public FrmListas()
        {
            InitializeComponent();

            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from lista in context.Listas select lista).ToList();
            }
        }

        private void alterarToolStripButton_Click(object sender, System.EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            using (var frm = new FrmListaCadastro(id))
                frm.ShowDialog();
        }
    }
}
