using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Application.Interface;
using ProjetoAPI.Domain.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly IUsuariosAppService _usuariosAppService;

        public LoginController(IUsuariosAppService usuariosAppService)
        {
            _usuariosAppService = usuariosAppService;
        }

        [HttpPost]
        public IActionResult Login(Usuarios model)
        {
            if (ModelState.IsValid)
            {
                var usuario = _usuariosAppService.Logar(model.Apelido, model.Senha);
                if (usuario != null)
                {
                    return Ok(usuario);
                }
                return Unauthorized(); //401
            }
            return BadRequest(); //400
        }
    }
}