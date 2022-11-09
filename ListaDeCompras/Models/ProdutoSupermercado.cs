namespace ListaDeCompras.Models
{
    public class ProdutoSupermercado : BaseModel
    {
        public string CodigoProduto { get; set; }
        public virtual Produto Produto { get; set; }
        public int IdSupermercado { get; set; }
        public virtual Supermercado Supermercado { get; set; }
        public double Preco { get; set; }
    }
}
