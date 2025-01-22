using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloCliente.BC.Excepciones;

namespace ModuloCliente.BC.ReglaDeNegocio
{
    public class ReglaGeneral
    {

        public static void validarId(int idSolicitud)
        {
            if (idSolicitud <= 0)
                throw new ErrorCampoExcepcion("ID inválido. Debe ser mayor a 0");
            
        }

    }
}
