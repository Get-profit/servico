using ProjetoAPI.Domain.Context;
using ProjetoAPI.Domain.Entities;
using ProjetoAPI.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoAPI.Infrastructure.Data.Repositories
{
    public class OrdemServicoRepository : RepositoryBase<OrdemServico>, IOrdemServicoRepository
    {
        public List<OrdemServico> RecuperaListaOrdemServico()
        {
            List<OrdemServico> model = null;
            using (AcessoriosContext db = new AcessoriosContext())
            {
                model = (from os in db.OrdemServico
                         join cli in db.Clientes on os.IdCliente equals cli.Id
                         orderby os.Status == "Aberto", os.DataEntrada descending
                         select new OrdemServico() 
                         { 
                            Id = os.Id,
                            DataEntrada = os.DataEntrada,
                            DataSaida = os.DataSaida,
                            Defeito = os.Defeito,
                            SenhaDesbloqueio = os.SenhaDesbloqueio,
                            Descricao = os.Descricao,
                            Marca = os.Marca,
                            Modelo = os.Modelo,
                            Status = os.Status,
                            Tipo = os.Tipo,
                            ValorOrcado = os.ValorOrcado,
                            IdCliente = os.IdCliente,
                            IdClienteNavigation = new Clientes()
                            {
                                Id = cli.Id,
                                Nome = cli.Nome
                            }
                         }).ToList();
            }
            return model;
        }

        public List<OrdemServico> RecuperaListaOrdemServicoAberta()
        {
            List<OrdemServico> model = null;
            using (AcessoriosContext db = new AcessoriosContext())
            {
                model = (from os in db.OrdemServico
                         join cli in db.Clientes on os.IdCliente equals cli.Id
                         where os.Status == "Aberto"
                         orderby os.DataEntrada descending
                         select new OrdemServico()
                         {
                             Id = os.Id,
                             DataEntrada = os.DataEntrada,
                             DataSaida = os.DataSaida,
                             Defeito = os.Defeito,
                             SenhaDesbloqueio = os.SenhaDesbloqueio,
                             Descricao = os.Descricao,
                             Marca = os.Marca,
                             Modelo = os.Modelo,
                             Status = os.Status,
                             Tipo = os.Tipo,
                             ValorOrcado = os.ValorOrcado,
                             IdCliente = os.IdCliente,
                             IdClienteNavigation = new Clientes()
                             {
                                 Id = cli.Id,
                                 Nome = cli.Nome
                             }
                         }).ToList();
            }
            return model;
        }

        public OrdemServico RecuperaOrdemServico(int id)
        {
            OrdemServico model = null;
            using (AcessoriosContext db = new AcessoriosContext())
            {
                model = (from os in db.OrdemServico
                         join cli in db.Clientes on os.IdCliente equals cli.Id
                         where os.Id == id
                         select new OrdemServico()
                         {
                             Id = os.Id,
                             DataEntrada = os.DataEntrada,
                             DataSaida = os.DataSaida,
                             Defeito = os.Defeito,
                             SenhaDesbloqueio = os.SenhaDesbloqueio,
                             Descricao = os.Descricao,
                             Marca = os.Marca,
                             Modelo = os.Modelo,
                             Status = os.Status,
                             Tipo = os.Tipo,
                             ValorOrcado = os.ValorOrcado,
                             IdCliente = os.IdCliente,
                             IdClienteNavigation = new Clientes()
                             {
                                 Id = cli.Id,
                                 Nome = cli.Nome
                             }
                         }).FirstOrDefault();
            }
            return model;
        }
    }
}
