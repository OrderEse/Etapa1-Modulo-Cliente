using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloCliente.BC.LogicaDeNegocio;
using ModuloCliente.BC.Modelos;
using ModuloCliente.BC.ReglaDeNegocio;
using ModuloCliente.BW.Interfaces.BW;
using ModuloCliente.BW.Interfaces.DA;

namespace ModuloCliente.BW.CU
{
    public class GestionarSolicitudBW : IGestionarSolicitudBW
    {

        private readonly IGestionarSolicitudDA gestionarSolicitudDA;

        public GestionarSolicitudBW(IGestionarSolicitudDA gestionarSolicitudDA)
        {
            this.gestionarSolicitudDA = gestionarSolicitudDA;
        }

        public async Task<bool> CancelarSolicitud(int idSolicitud)
        {
            ReglaGeneral.validarId(idSolicitud);
            return await this.gestionarSolicitudDA.CancelarSolicitud(idSolicitud);
        }

        public async Task<bool> RealizarSolicitud(Solicitud solicitud)
        {
            LogicaDeSolicitud.ValidarSolicitud(solicitud);
            return await this.gestionarSolicitudDA.RealizarSolicitud(solicitud);
        }
    }
}
