using System;
using System.Collections.Generic;

namespace ListaDeCompras.Models
{
    public class Lista : BaseModel
    {
        public DateTime Data { get; set; }
        public bool EstaAtiva { get; set; }
        public double Total { get; set; }
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
