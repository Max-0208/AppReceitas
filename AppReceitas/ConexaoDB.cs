using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReceitas
{
    static class ConexaoDB
    {
        private const string servidor = "LocalHost";
        private const string db = "dbReceitas";
        private const string usuario = "root";
        private const string senha = "Matheus@32876122";

        static public string conexaoDB = $"server={servidor}; user id={usuario}; database={db}; password={senha}";
    }
}
