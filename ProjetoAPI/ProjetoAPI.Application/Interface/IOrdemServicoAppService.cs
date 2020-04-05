using ProjetoAPI.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoAPI.Application.Interface
{
    public interface IOrdemServicoAppService : IAppServiceBase<OrdemServico>
    {
        List<OrdemServico> RecuperaListaOrdemServico();
        OrdemServico RecuperaOrdemServico(int id);
    }
}
