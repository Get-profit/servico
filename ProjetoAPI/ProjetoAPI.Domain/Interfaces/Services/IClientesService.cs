using ProjetoAPI.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoAPI.Domain.Interfaces.Services
{
    public interface IClientesService : IServiceBase<Clientes>
    {
        List<Clientes> LocalizarClientePorNome(string nome);
    }
}
