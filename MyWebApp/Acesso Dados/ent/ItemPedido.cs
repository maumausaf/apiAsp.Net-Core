namespace MyWebApp.Entidades
{
    public class ItemPedido
    {
        public int id { get; set; }
        public Produto Produto { get; set; }        
        public int Quantidade { get; set; }
    }
}
