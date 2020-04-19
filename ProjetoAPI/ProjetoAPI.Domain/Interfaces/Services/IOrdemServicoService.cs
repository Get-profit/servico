using ProjetoAPI.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoAPI.Domain.Interfaces.Services
{
    public interface IOrdemServicoService : IServiceBase<OrdemServico>
    {
        List<OrdemServico> RecuperaListaOrdemServico();
        List<OrdemServico> RecuperaListaOrdemServicoAberta();
        OrdemServico RecuperaOrdemServico(int id);
    }
}
