using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class UsuariosModel
    {
        public int Id { get; set; }
        public string Apelido { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }
    }
}
