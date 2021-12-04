using ApiFormulario.Interfaces;
using ApiFormulario.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFormulario.Repositorio
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly IRepositoryConnection _repositoryConnection;

        private readonly Dictionary<string, string> parameters = new Dictionary<string, string>();
        public UsuariosRepository(IRepositoryConnection repositoryConnection)
        {
            _repositoryConnection = repositoryConnection;
        }
        public List<Usuarios> GetUsuarios()
        {
            try
            {
                List<Usuarios> listUsuarios = new List<Usuarios>();
                Usuarios usuario = null;

                var read = _repositoryConnection.SearchCommand("GetAllUsuarios", parameters);

                DataTable data = JsonConvert.DeserializeObject<DataTable>(read);

                foreach (DataRow row in data.Rows)
                {
                    usuario = new Usuarios();

                    usuario.UsuarioId = Convert.ToInt32(row["USUARIO_ID"]);
                    usuario.Nome = row["NOME"].ToString();
                    usuario.Sobrenome = row["SOBRENOME"].ToString();
                    usuario.Email = row["EMAIL"].ToString();
                    usuario.Telefone = row["TELEFONE"].ToString();

                    listUsuarios.Add(usuario);
                }
                return listUsuarios;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int InsertUsuario([FromBody]Usuarios usuario)
        {
            try
            {
                parameters.Clear();
                parameters.Add("@NOME", usuario.Nome);
                parameters.Add("@SOBRENOME", usuario.Sobrenome);
                parameters.Add("@EMAIL", usuario.Email);
                parameters.Add("@TELEFONE", usuario.Telefone);

                int usuarioId = _repositoryConnection.InsertCommand("InsertUsuario", parameters);

                return usuarioId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
