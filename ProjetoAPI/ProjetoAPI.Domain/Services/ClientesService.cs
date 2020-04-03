using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Repositories;
using ProjetoAPI.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoAPI.Domain.Services
{
    public class ClientesService : ServiceBase<Clientes>, IClientesService
    {
        private readonly IClientesRepository _clientesRepository;

        public ClientesService(IClientesRepository clientesRepository) : base(clientesRepository)
        {
            _clientesRepository = clientesRepository;
        }

        public List<Clientes> LocalizarClientePorNome(string nome)
        {
            return _clientesRepository.LocalizarClientePorNome(nome);
        }
    }
}
