using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsuarioPermissao.API.data;
using UsuarioPermissao.Models;

namespace UsuarioPermissao.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly DataContext _context;

        public UsuariosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Usuarios);
        }


        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var usuarioEncontrado = _context.Usuarios.FirstOrDefault(a => a.Id == id);
            if (usuarioEncontrado == null) return BadRequest("O usuario não foi encontrado");
            return Ok(usuarioEncontrado);
        }


        //api/aluno/byName?nome=Pedro&sobreNome=Ferreira
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var usuarioEncontrado = _context.Usuarios.FirstOrDefault(a => a.Nome.Contains(nome));
            if (usuarioEncontrado == null) return BadRequest("O usuario não foi encontrado");

            return Ok(usuarioEncontrado);
        }


        [HttpPost]
        public IActionResult Post(Usuarios usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuarios usuario)
        {
            var usuarioEncontrado = _context.Usuarios.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (usuarioEncontrado == null) return BadRequest("Usuario não encontrado");
            _context.Update(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var usuarioEncontrado = _context.Usuarios.FirstOrDefault(a => a.Id == id);
            if (usuarioEncontrado == null) return BadRequest("Usuario não encontrado");
            _context.Remove(usuarioEncontrado);
            _context.SaveChanges();
            return Ok();
        }
    }



}