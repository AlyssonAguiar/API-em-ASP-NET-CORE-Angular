using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFormulario.Interfaces
{
    public interface IRepositoryConnection
    {
        public string SearchCommand(string procedure, Dictionary<string, string> parameters);
        public int InsertCommand(string procedure, Dictionary<string, string> parameters);
        public void SimpleExecuteCommand(string procedure, Dictionary<string, string> parameters);
    }
}
