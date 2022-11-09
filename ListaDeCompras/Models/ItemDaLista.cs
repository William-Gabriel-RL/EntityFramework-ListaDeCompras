namespace ListaDeCompras.Models
{
    public class ItemDaLista : BaseModel
    {
        public int IdLista { get; set; }
        public virtual Lista Lista { get; set; }
        public string CodigoProduto { get; set; }
        public virtual Produto Produto { get; set; }
        public int IdSupermercado { get; set; }
        public virtual Supermercado Supermercado { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public bool Comprado { get; set; }
    }
}
