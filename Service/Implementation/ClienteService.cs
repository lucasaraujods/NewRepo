using AppVendasBlazor.Data.Context;
using AppVendasBlazor.Model;
using AppVendasBlazor.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace AppVendasBlazor.Service.Implementation
{
    public class ClienteService : IClienteService
    {
        private readonly SqlServerContext _context;

        public ClienteService(SqlServerContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Cliente cliente)
        {
             _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int Id)
        {
            var cliente = await _context.Clientes.FindAsync(Id);
            if(cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Cliente> ObterPorIdAsync(int Id)
        {
            return await _context.Clientes.FindAsync(Id);
        }

        public Task<Cliente> ObterPorIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> ObterTodosAsync()
        {
            return await _context.Clientes.ToListAsync();
        }
    }
}
