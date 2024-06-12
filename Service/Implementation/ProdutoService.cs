using AppVendasBlazor.Data.Context;
using AppVendasBlazor.Model;
using AppVendasBlazor.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace AppVendasBlazor.Service.Implementation
{
    public class ProdutoService:IProdutoService
    {
        private readonly SqlServerContext _context;

        public ProdutoService(SqlServerContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Produto produto)
        {
             _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int Id)
        {
            var produto = await _context.Produtos.FindAsync(Id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Produto> ObterPorIdAsync(int Id)
        {
            return await _context.Produtos.FindAsync(Id); 

        }

        public Task<Produto> ObterPorIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Produto>> ObterTodosAsync()
        {
            return await _context.Produtos.ToListAsync();
        }
    }


}
