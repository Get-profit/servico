using System.Collections.Generic;
using System.Threading.Tasks;
using API.AutoMapper;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Application.Interface;
using ProjetoAPI.Domain.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        private readonly IClientesAppService _clientesAppService;

        public ClientesController(IClientesAppService clientesAppService)
        {
            _clientesAppService = clientesAppService;
        }

        [HttpGet]
        public IActionResult RecuperarTodos()
        {
            var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
            var model = mapper.Map<IEnumerable<Clientes>, IEnumerable<ClientesModel>>(_clientesAppService.GetAll());
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult Recuperar(int id)
        {
            var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
            var model = mapper.Map<ClientesModel>(_clientesAppService.GetById(id));
            if (model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        [HttpPost]
        public IActionResult Inserir([FromBody] ClientesModel model)
        {
            if (ModelState.IsValid)
            {
                var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
                var clienteDomain = mapper.Map<ClientesModel, Clientes>(model);
                _clientesAppService.Add(clienteDomain);
                var uri = Url.Action("Recuperar", new { id = clienteDomain.Id });
                return Created(uri, clienteDomain); //201
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] ClientesModel model)
        {
            if (ModelState.IsValid)
            {
                var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
                var clienteDomain = mapper.Map<ClientesModel, Clientes>(model);
                _clientesAppService.Update(clienteDomain);
                return Ok(); //200
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id)
        {
            var model = _clientesAppService.GetById(id);
            if (model == null)
            {
                return NotFound();
            }
            _clientesAppService.Remove(model);
            return NoContent(); //203
        }

        [HttpPost("{prefix}")]
        public IActionResult BuscarClientePorNome(string prefix)
        {
            var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
            var clientes = mapper.Map<List<ClientesModel>>(_clientesAppService.LocalizarClientePorNome(prefix));
            if (clientes == null)
            {
                return NotFound();
            }
            return Ok(clientes);
        }
    }
}