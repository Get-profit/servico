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
    public class UsuariosController : Controller
    {
        private readonly IUsuariosAppService _usuariosAppService;

        public UsuariosController(IUsuariosAppService usuariosAppService)
        {
            _usuariosAppService = usuariosAppService;
        }

        [HttpGet]
        public IActionResult RecuperarTodos()
        {
            var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
            var model = mapper.Map<IEnumerable<Usuarios>, IEnumerable<UsuariosModel>>(_usuariosAppService.GetAll());
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult Recuperar(int id)
        {
            var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
            var model = mapper.Map<UsuariosModel>(_usuariosAppService.GetById(id));
            if (model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        [HttpPost]
        public IActionResult Inserir([FromBody] UsuariosModel model)
        {
            if (ModelState.IsValid)
            {
                var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
                var usuarioDomain = mapper.Map<UsuariosModel, Usuarios>(model);
                _usuariosAppService.Add(usuarioDomain);
                var uri = Url.Action("Recuperar", new { id = usuarioDomain.Id });
                return Created(uri, usuarioDomain); //201
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] UsuariosModel model)
        {
            if (ModelState.IsValid)
            {
                var mapper = new Mapper(AutoMapperConfig.RegisterMappings());
                var usuarioDomain = mapper.Map<UsuariosModel, Usuarios>(model);
                _usuariosAppService.Update(usuarioDomain);
                return Ok(); //200
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id)
        {
            var model = _usuariosAppService.GetById(id);
            if (model == null)
            {
                return NotFound();
            }
            _usuariosAppService.Remove(model);
            return NoContent(); //203
        }
    }
}