using AppVendasBlazor.Model;

namespace AppVendasBlazor.Service.Interface
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> ObterTodosAsync();
        Task<Cliente> ObterPorIdAsync();
        Task AdicionarAsync(Cliente cliente);
        Task AlterarAsync(Cliente cliente);
        Task ExcluirAsync(int Id);
    }
}
