using ListaDeCompras.Data;
using ListaDeCompras.Models;
using System;
using System.Windows.Forms;

namespace ListaDeCompras.Forms
{
    public partial class FrmSupermercadoCadastro : Form
    {
        public FrmSupermercadoCadastro(int id, string operacao = "a")
        {
            InitializeComponent();

            if (id != 0)
                ObterSupermercado(id);

            if (operacao == "v")
            {
                Text = "Visualizar supermercado";
                salvarToolStripButton.Visible = false;
                TravarFormulario();
            }
            else if (operacao == "e")
            {
                Text = "Excluir supermercado";
                salvarToolStripButton.Visible = false;
                excluirToolStripButton.Visible = true;
                TravarFormulario();
            }
        }

        private void TravarFormulario()
        {
            textoNome.ReadOnly = true;
            textoLogradouro.ReadOnly = true;
            textoBairro.ReadOnly = true;
            textoCidade.ReadOnly = true;
            textoEstado.ReadOnly = true;
            textoCEP.ReadOnly = true;
        }

        private void ObterSupermercado(int id)
        {
            textId.Text = id.ToString();

            try
            {
                using (var context = new DataContext())
                {
                    var supermercado = context.Supermercados.Find(id);
                    if (supermercado != null)
                    {
                        textoNome.Text = supermercado.Nome;
                        textoLogradouro.Text = supermercado.Logradouro;
                        textoBairro.Text = supermercado.Bairro;
                        textoCidade.Text = supermercado.Cidade;
                        textoEstado.Text = supermercado.Estado;
                        textoCEP.Text = supermercado.CEP;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao salvar.\n" + ex.Message);
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (Salvar())
                Close();
        }

        private bool Salvar()
        {
            var supermercado = new Supermercado();

            supermercado.Id = Convert.ToInt32("0" + textId.Text);
            supermercado.Nome = textoNome.Text;
            supermercado.Logradouro = textoLogradouro.Text;
            supermercado.Bairro = textoBairro.Text;
            supermercado.Cidade = textoCidade.Text;
            supermercado.Estado = textoEstado.Text;
            supermercado.CEP = textoCEP.Text;

            try
            {
                using (var context = new DataContext())
                {
                    if (supermercado.Id == 0)
                        context.Supermercados.Add(supermercado);
                    else
                        context.Entry(supermercado).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao salvar.\n" + ex.Message);
                return false;
            }
        }

        private void excluirToolStripButton_Click(object sender, EventArgs e)
        {
            if (Excluir())
                Close();
        }

        private bool Excluir()
        {
            try
            {
                using (var context = new DataContext())
                {
                    var supermercado = new Supermercado();
                    supermercado.Id = Convert.ToInt32(textId.Text);
                    var entry = context.Entry(supermercado);

                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        context.Supermercados.Attach(supermercado);

                    context.Supermercados.Remove(supermercado);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao excluir usuário.\n" + ex.Message);
                return false;
            }
        }
    }
}
