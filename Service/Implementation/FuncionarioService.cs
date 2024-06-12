using AppVendasBlazor.Data.Context;
using AppVendasBlazor.Model;
using AppVendasBlazor.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace AppVendasBlazor.Service.Implementation
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly SqlServerContext _context;

        public FuncionarioService(SqlServerContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Funcionario funcionario)
        {
            await _context.funcionario.AddAsync(funcionario);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Funcionario funcionario)
        {
            _context.funcionario.AddAsync(funcionario);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int Id)
        {
            var funcionario = await _context.funcionario.FindAsync(Id);
            if (funcionario != null)
            {
                _context.funcionario.Remove(funcionario);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Funcionario> ObterPorIdAsync(int Id)
        {
            return await _context.funcionario.FindAsync(Id);
        }

        public Task<Funcionario> ObterPorIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Funcionario>> ObterTodosAsync()
        {
            return await _context.funcionario.ToListAsync();
        }
    }
}

