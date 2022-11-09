using System.Collections.Generic;

namespace ListaDeCompras.Models
{
    public class Supermercado : BaseModel
    {
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public virtual ICollection<ProdutoSupermercado> ProdutoSupermercado { get; set; }
        public virtual ICollection<ItemDaLista> ItemDaLista { get; set; }
    }
}
