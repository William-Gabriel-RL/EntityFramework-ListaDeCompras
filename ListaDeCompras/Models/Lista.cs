using System;

namespace ListaDeCompras.Models
{
    public class Lista : BaseModel
    {
        public DateTime Data { get; set; }
        public bool EstaAtiva { get; set; }
        public double Total { get; set; }
        public int IdUsuario { get; set; }
    }
}
