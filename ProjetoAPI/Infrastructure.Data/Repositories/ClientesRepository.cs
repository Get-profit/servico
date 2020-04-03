using ProjetoAPI.Domain.Context;
using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoAPI.Infrastructure.Data.Repositories
{
    public class ClientesRepository : RepositoryBase<Clientes>, IClientesRepository
    {
        public List<Clientes> LocalizarClientePorNome(string nome)
        {
            List<Clientes> model = null;
            using (AcessoriosContext db = new AcessoriosContext())
            {
                model = (from cli in db.Clientes
                         where cli.Nome.Contains(nome)
                         orderby cli.Nome
                         select cli).ToList();
            }
            return model;
        }
    }
}
