using ListaDeCompras.Data;
using ListaDeCompras.Models;
using System;
using System.Windows.Forms;

namespace ListaDeCompras.Forms
{
    public partial class FrmListaCadastro : Form
    {
        public FrmListaCadastro(int id)
        {
            InitializeComponent();

            if (id != 0)
                ObterLista(id);
        }


        private void ObterLista(int id)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var lista = context.Listas.Find(id);
                    var usuario = context.Usuarios.Find(lista.IdUsuario);
                    if (lista != null)
                    {
                        textoUsuario.Text = usuario.Nome;
                        textoData.Text = Convert.ToString(lista.Data);
                        textoTotal.Text = Convert.ToString(lista.Total);
                        checkBoxEstaAtiva.Checked = lista.EstaAtiva;
                    }
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
