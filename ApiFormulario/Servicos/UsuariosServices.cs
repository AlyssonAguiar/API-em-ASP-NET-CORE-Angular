using ApiFormulario.Interfaces;
using ApiFormulario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFormulario.Servicos
{
    public class UsuariosServices : IUsuarioServices
    {
        private readonly IUsuariosRepository _usuariosRepository;
        public UsuariosServices(IUsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }
        public IEnumerable<Usuarios> GetAllUsuarios()
        {
            return _usuariosRepository.GetUsuarios();
        }

        public void InsertUsuario(Usuarios usuario)
        {
            _usuariosRepository.InsertUsuario(usuario);
        }
    }
}
