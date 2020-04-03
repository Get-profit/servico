using ProjetoAPI.Domain.Entities;

namespace ProjetoAPI.Domain.Interfaces.Repositories
{
    public interface IUsuariosRepository : IRepositoryBase<Usuarios>
    {
        Usuarios Logar(string login, string senha);
    }
}
