using System.ComponentModel.DataAnnotations.Schema;

namespace AppVendasBlazor.Model
{
    [Table("tbItemVenda")]
    public class ItemVenda
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int PedidoId { get; set; }
        public Pedido pedido { get; set; }
        public int QuantidadeProduto { get; set;}
        public double PrecoUnitatio { get; set; }
        public ICollection<ItemVenda> ItemVendas { get; set; }

    }
}
