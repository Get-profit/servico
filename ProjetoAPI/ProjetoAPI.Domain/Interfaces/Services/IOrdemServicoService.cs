using ProjetoAPI.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoAPI.Domain.Interfaces.Services
{
    public interface IOrdemServicoService : IServiceBase<OrdemServico>
    {
        List<OrdemServico> RecuperaListaOrdemServico();
        OrdemServico RecuperaOrdemServico(int id);
    }
}
