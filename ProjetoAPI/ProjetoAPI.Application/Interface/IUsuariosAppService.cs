using ProjetoAPI.Domain.Entities;

namespace ProjetoAPI.Application.Interface
{
    public interface IUsuariosAppService : IAppServiceBase<Usuarios>
    {
        Usuarios Logar(string login, string senha);
    }
}
