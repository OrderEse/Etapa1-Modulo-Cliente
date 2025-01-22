using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCliente.BC.Excepciones
{
    public class ErrorCampoExcepcion : Exception
    {

        public ErrorCampoExcepcion(string mensaje) : base(mensaje) { }
    }
}
