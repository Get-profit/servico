using System;
using System.Collections.Generic;

namespace ProjetoAPI.Domain.Entities
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Apelido { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }
    }
}
