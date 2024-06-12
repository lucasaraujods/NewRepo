using AppVendasBlazor.Model;

namespace AppVendasBlazor.Service.Interface
{
    public interface IFuncionarioService
    {
        Task<IEnumerable<Funcionario>> ObterTodosAsync();
        Task<Funcionario> ObterPorIdAsync();
        Task AdicionarAsync(Funcionario funcionario);
        Task AlterarAsync(Funcionario funcionario);
        Task ExcluirAsync(int Id);
    }
}
