using System;
using System.Collections.Generic;

namespace MyWebApp.Entidades
{
    public class Pedido
    {
        public int id { get; set; }
        public DateTime DatePedido { get; set; }
        public ICollection <ItemPedido> ItensPedidos { get; set; }

    }
}
