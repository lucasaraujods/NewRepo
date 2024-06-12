using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace AppVendasBlazor.Model
{
    [Table("tbFuncionario")]
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required]
        [StringLength(100)]
        public string Cpf { get;}
        public string Email { get; set; }       
        public string Cargo { get; set; }
        [Column (TypeName = "decimal(18,2)")]
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }


    }
}

