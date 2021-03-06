﻿using ProjetoAPI.Domain.Entities;

namespace ProjetoAPI.Domain.Interfaces.Services
{
    public interface IUsuariosService : IServiceBase<Usuarios>
    {
        Usuarios Logar(string login, string senha);
    }
}
