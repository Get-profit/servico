using ProjetoAPI.Domain.Context;
using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Repositories;
using System.Linq;

namespace ProjetoAPI.Infrastructure.Data.Repositories
{
    public class OrdemServicoRepository : RepositoryBase<OrdemServico>, IOrdemServicoRepository
    {
    }
}
