using ApiFormulario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFormulario.Interfaces
{
    public interface IUsuariosRepository
    {
        public List<Usuarios> GetUsuarios();
        public int InsertUsuario(Usuarios usuario);
    }
}
