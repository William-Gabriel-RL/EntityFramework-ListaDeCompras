using ListaDeCompras.Models;
using System.Collections.Generic;

namespace ListaDeCompras
{
    public class Produto
    {
        public string CodigoDeBarras { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Foto { get; set; }
        public virtual ICollection<ProdutoSupermercado> ProdutoSupermercado { get; set; }
        public virtual ICollection<ItemDaLista> ItemDaLista { get; set; }

    }
}
