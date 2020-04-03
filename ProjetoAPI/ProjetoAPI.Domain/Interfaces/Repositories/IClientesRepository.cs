using ProjetoAPI.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoAPI.Domain.Interfaces.Repositories
{
    public interface IClientesRepository: IRepositoryBase<Clientes>
    {
        List<Clientes> LocalizarClientePorNome(string nome);
    }
}
