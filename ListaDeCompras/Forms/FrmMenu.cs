using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            using(var frm = new FrmUsuarios())
            {
                frm.ShowDialog();
            }
        }

        private void btnSupermercados_Click(object sender, EventArgs e)
        {
            using(var frm = new FrmSupermercados())
            {
                frm.ShowDialog();
            }
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            using(var frm = new FrmListas())
            {
                frm.ShowDialog();
            }
        }
    }
}
