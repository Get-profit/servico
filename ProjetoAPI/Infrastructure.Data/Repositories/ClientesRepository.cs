using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Repositories;

namespace ProjetoAPI.Infrastructure.Data.Repositories
{
    public class ClientesRepository : RepositoryBase<Clientes>, IClientesRepository
    {
    }
}
