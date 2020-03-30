using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Repositories;
using ProjetoAPI.Domain.Interfaces.Services;

namespace ProjetoAPI.Domain.Services
{
    public class OrdemServicoService : ServiceBase<OrdemServico>, IOrdemServicoService
    {
        private readonly IOrdemServicoRepository _ordemServicoRepository;

        public OrdemServicoService(IOrdemServicoRepository ordemServicoRepository) : base(ordemServicoRepository)
        {
            _ordemServicoRepository = ordemServicoRepository;
        }
    }
}
