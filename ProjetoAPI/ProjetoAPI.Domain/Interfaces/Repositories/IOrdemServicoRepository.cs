using ProjetoAPI.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoAPI.Domain.Interfaces.Repositories
{
    public interface IOrdemServicoRepository : IRepositoryBase<OrdemServico>
    {
        List<OrdemServico> RecuperaListaOrdemServico();
        List<OrdemServico> RecuperaListaOrdemServicoAberta();
        OrdemServico RecuperaOrdemServico(int id);
    }
}
