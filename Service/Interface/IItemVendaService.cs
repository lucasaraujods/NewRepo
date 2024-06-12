using AppVendasBlazor.Model;

namespace AppVendasBlazor.Service.Interface
{
    public interface IItemVendaService
    {       
        Task AdicionarAsync(ItemVenda itemvenda);      
        Task ExcluirAsync(int Id);
    }
}
