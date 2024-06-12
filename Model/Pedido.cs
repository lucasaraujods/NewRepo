using System.ComponentModel.DataAnnotations.Schema;

namespace AppVendasBlazor.Model
{
    [Table("tbPedido")]
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido{ get; set; }
        public int FuncionarioId { get;set; }
        public Funcionario Funcionario { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public double ValorTotal { get; set; }
         public ICollection<ItemVenda> ItemVendas { get; set; }
    }
}
