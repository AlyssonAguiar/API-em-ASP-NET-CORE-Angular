using ApiFormulario.Interfaces;
using ApiFormulario.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFormulario.Controllers
{
    [ApiController]
    [Route("ApiFormulario/[controller]")]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioServices _usuarioServices;

        public UsuariosController(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
        }

        [HttpGet]
        public IActionResult GetAllUsuarios()
        {
            var listUsuarios = _usuarioServices.GetAllUsuarios();
            return Ok(listUsuarios);
        }

        [HttpPost]
        public IActionResult InserUsuario(Usuarios usuario)
        {
            if (usuario == null)
                return BadRequest();

            _usuarioServices.InsertUsuario(usuario);
            return Ok();
        }
    }
}
