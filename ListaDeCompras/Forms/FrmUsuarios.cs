using ListaDeCompras.Data;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();

            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from usuario in context.Usuarios select usuario).ToList();
            }
    }

        private void adicionarStripButton_Click(object sender, System.EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, System.EventArgs e)
        {

        }
    }
}
