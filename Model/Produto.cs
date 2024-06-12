using System.ComponentModel.DataAnnotations.Schema;

namespace AppVendasBlazor.Model
{
    [Table ("tbProduto")]
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string UnidadeMedida { get; set; }
        public double PrecoUnitario { get; set; }
        public ICollection<ItemVenda> ItemVendas { get; set; }
    }
}
