using ApiFormulario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFormulario.Interfaces
{
    public interface IUsuarioServices
    {
        public IEnumerable<Usuarios> GetAllUsuarios();
        public void InsertUsuario(Usuarios usuario);
    }
}
