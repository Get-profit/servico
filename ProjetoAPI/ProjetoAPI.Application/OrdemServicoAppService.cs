using ProjetoAPI.Application.Interface;
using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Services;

namespace ProjetoAPI.Application
{
    public class OrdemServicoAppService : AppServiceBase<OrdemServico>, IOrdemServicoAppService
    {
        private readonly IOrdemServicoService _ordemServicoService;

        public OrdemServicoAppService(IOrdemServicoService ordemServicoService) : base(ordemServicoService)
        {
            _ordemServicoService = ordemServicoService;
        }
    }
}
