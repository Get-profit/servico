using AutoMapper;
using API.Models;
using ProjetoAPI.Domain.Entities;

namespace API.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public static MapperConfiguration RegisterMappings()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Usuarios, UsuariosModel>();
                cfg.CreateMap<UsuariosModel, Usuarios>();
                cfg.CreateMap<Clientes, ClientesModel>();
                cfg.CreateMap<ClientesModel, Clientes>();
                cfg.CreateMap<OrdemServico, OrdemServicoModel>();
                cfg.CreateMap<OrdemServicoModel, OrdemServico>();
            });
            return config;

        }
    }
}
