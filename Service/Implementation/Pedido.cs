using AppVendasBlazor.Data.Context;
using AppVendasBlazor.Model;
using AppVendasBlazor.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace AppVendasBlazor.Service.Implementation
{
    public class Pedido:IPedidoService
    {
        private readonly SqlServerContext _context;

        public Pedido(SqlServerContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Model.Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Model.Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int Id)
        {
            var pedido = await _context.Pedidos.FindAsync(Id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Model.Pedido> ObterPorIdAsync(int Id)
        {
            return await _context.Pedidos.FindAsync(Id);
        }

        public Task<Model.Pedido> ObterPorIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Model.Pedido>> ObterTodosAsync()
        {
            return await _context.Pedidos.ToListAsync();
        }
    }
}
