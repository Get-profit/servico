using ProjetoAPI.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoAPI.Application.Interface
{
    public interface IOrdemServicoAppService : IAppServiceBase<OrdemServico>
    {
        List<OrdemServico> RecuperaListaOrdemServico();
        List<OrdemServico> RecuperaListaOrdemServicoAberta();
        OrdemServico RecuperaOrdemServico(int id);
    }
}
