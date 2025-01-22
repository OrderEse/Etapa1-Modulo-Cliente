using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloCliente.BC.Modelos;

namespace ModuloCliente.BW.Interfaces.DA
{
    public interface IGestionarSolicitudDA
    {
        public Task<Boolean> RealizarSolicitud(Solicitud solicitud);

        public Task<Boolean> CancelarSolicitud(int idSolicitud);

    }
}
