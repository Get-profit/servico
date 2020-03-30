using ProjetoAPI.Application.Interface;
using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Services;

namespace ProjetoAPI.Application
{
    public class ClientesAppService : AppServiceBase<Clientes>, IClientesAppService
    {
        private readonly IClientesService _clientesService;

        public ClientesAppService(IClientesService clientesService) : base(clientesService)
        {
            _clientesService = clientesService;
        }
    }
}
