using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Repositories;
using ProjetoAPI.Domain.Interfaces.Services;

namespace ProjetoAPI.Domain.Services
{
    public class ClientesService : ServiceBase<Clientes>, IClientesService
    {
        private readonly IClientesRepository _clientesRepository;

        public ClientesService(IClientesRepository clientesRepository) : base(clientesRepository)
        {
            _clientesRepository = clientesRepository;
        }
    }
}
