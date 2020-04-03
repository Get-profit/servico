using System;
using System.Collections.Generic;
using System.Linq;
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
    public class OrdemServicoController : Controller
    {
        private readonly IOrdemServicoAppService _ordemServicoAppService;

        public OrdemServicoController(IOrdemServicoAppService ordemServicoAppService)
        {
            _ordemServicoAppService = ordemServicoAppService;
        }

        [HttpGet]
        public IActionResult RecuperarTodos()
        {
            var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
            var model = mapper.Map<IEnumerable<OrdemServico>, IEnumerable<OrdemServicoModel>>(_ordemServicoAppService.GetAll());
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult Recuperar(int id)
        {
            var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
            var model = mapper.Map<OrdemServicoModel>(_ordemServicoAppService.GetById(id));
            if (model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        [HttpPost]
        public IActionResult Inserir([FromBody] OrdemServicoModel model)
        {
            if (ModelState.IsValid)
            {
                var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
                var ordemServicoDomain = mapper.Map<OrdemServicoModel, OrdemServico>(model);
                _ordemServicoAppService.Add(ordemServicoDomain);
                var uri = Url.Action("Recuperar", new { id = ordemServicoDomain.Id });
                return Created(uri, ordemServicoDomain); //201
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] OrdemServicoModel model)
        {
            if (ModelState.IsValid)
            {
                var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
                var ordemServicoDomain = mapper.Map<OrdemServicoModel, OrdemServico>(model);
                _ordemServicoAppService.Update(ordemServicoDomain);
                return Ok(); //200
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id)
        {
            var model = _ordemServicoAppService.GetById(id);
            if (model == null)
            {
                return NotFound();
            }
            _ordemServicoAppService.Remove(model);
            return NoContent(); //203
        }
    }
}