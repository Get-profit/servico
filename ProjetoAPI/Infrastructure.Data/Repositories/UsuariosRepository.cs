using ProjetoAPI.Domain.Context;
using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Repositories;
using System.Linq;

namespace ProjetoAPI.Infrastructure.Data.Repositories
{
    public class UsuariosRepository : RepositoryBase<Usuarios>, IUsuariosRepository
    {
        public Usuarios Logar(string login, string senha)
        {
            Usuarios model = null;
            using (AcessoriosContext db = new AcessoriosContext())
            {
                model = (from u in db.Usuarios
                         where u.Apelido == login && u.Senha == senha
                         select new Usuarios()
                         {
                             Id = u.Id,
                             Apelido = u.Apelido,
                             Cargo = u.Cargo
                         }).FirstOrDefault();
            }
            return model;
        }
    }
}
