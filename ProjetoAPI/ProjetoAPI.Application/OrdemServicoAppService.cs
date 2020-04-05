using ProjetoAPI.Application.Interface;
using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoAPI.Application
{
    public class OrdemServicoAppService : AppServiceBase<OrdemServico>, IOrdemServicoAppService
    {
        private readonly IOrdemServicoService _ordemServicoService;

        public OrdemServicoAppService(IOrdemServicoService ordemServicoService) : base(ordemServicoService)
        {
            _ordemServicoService = ordemServicoService;
        }

        public List<OrdemServico> RecuperaListaOrdemServico()
        {
            return _ordemServicoService.RecuperaListaOrdemServico();
        }

        public OrdemServico RecuperaOrdemServico(int id)
        {
            return _ordemServicoService.RecuperaOrdemServico(id);
        }
    }
}
