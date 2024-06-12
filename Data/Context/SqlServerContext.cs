using AppVendasBlazor.Model;
using Microsoft.EntityFrameworkCore;

namespace AppVendasBlazor.Data.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> funcionario { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        //public DbSet<Pedido> Pedidos { get; set; }
        //public DbSet<ItemVenda> ItemVendas { get; set; }

    }
}
