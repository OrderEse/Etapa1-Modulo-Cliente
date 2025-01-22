using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloCliente.BC.Excepciones;
using ModuloCliente.BC.Modelos;

namespace ModuloCliente.BC.LogicaDeNegocio
{
    public class LogicaDeSolicitud
    {

       public static void ValidarSolicitud(Solicitud solicitud)
        {
            if (solicitud == null)
                throw new ErrorCampoExcepcion("La solicitud no puede ser nula");

        }

    }
}
