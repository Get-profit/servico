using ProjetoAPI.Application.Interface;
using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Services;

namespace ProjetoAPI.Application
{
    public class UsuariosAppService : AppServiceBase<Usuarios>, IUsuariosAppService
    {
        private readonly IUsuariosService _usuariosService;

        public UsuariosAppService(IUsuariosService usuariosService) : base(usuariosService)
        {
            _usuariosService = usuariosService;
        }

        public Usuarios Logar(string login, string senha)
        {
            return _usuariosService.Logar(login, senha);
        }
    }
}
