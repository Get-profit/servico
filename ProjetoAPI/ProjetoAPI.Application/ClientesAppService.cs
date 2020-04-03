using ProjetoAPI.Application.Interface;
using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoAPI.Application
{
    public class ClientesAppService : AppServiceBase<Clientes>, IClientesAppService
    {
        private readonly IClientesService _clientesService;

        public ClientesAppService(IClientesService clientesService) : base(clientesService)
        {
            _clientesService = clientesService;
        }

        public List<Clientes> LocalizarClientePorNome(string nome)
        {
            return _clientesService.LocalizarClientePorNome(nome);
        }
    }
}
