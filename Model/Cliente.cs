using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppVendasBlazor.Model
{
    [Table("tbCliente")]

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required]
        [StringLength(100)]
        public string Cpfcnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
            
    }
}
