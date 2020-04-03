using ProjetoAPI.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoAPI.Application.Interface
{
    public interface IClientesAppService : IAppServiceBase<Clientes>
    {
        List<Clientes> LocalizarClientePorNome(string nome);
    }
}
