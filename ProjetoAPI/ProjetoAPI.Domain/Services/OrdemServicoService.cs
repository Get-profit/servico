using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Repositories;
using ProjetoAPI.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoAPI.Domain.Services
{
    public class OrdemServicoService : ServiceBase<OrdemServico>, IOrdemServicoService
    {
        private readonly IOrdemServicoRepository _ordemServicoRepository;

        public OrdemServicoService(IOrdemServicoRepository ordemServicoRepository) : base(ordemServicoRepository)
        {
            _ordemServicoRepository = ordemServicoRepository;
        }

        public List<OrdemServico> RecuperaListaOrdemServico()
        {
            return _ordemServicoRepository.RecuperaListaOrdemServico();
        }

        public OrdemServico RecuperaOrdemServico(int id)
        {
            return _ordemServicoRepository.RecuperaOrdemServico(id);
        }
    }
}
