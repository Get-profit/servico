using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Repositories;
using ProjetoAPI.Domain.Interfaces.Services;

namespace ProjetoAPI.Domain.Services
{
    public class UsuariosService : ServiceBase<Usuarios>, IUsuariosService
    {
        private readonly IUsuariosRepository _usuariosRepository;

        public UsuariosService(IUsuariosRepository usuariosRepository) : base(usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }
    }
}
