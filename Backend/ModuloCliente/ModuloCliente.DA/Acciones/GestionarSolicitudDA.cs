using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloCliente.BC.Constantes;
using ModuloCliente.BC.Excepciones;
using ModuloCliente.BC.Modelos;
using ModuloCliente.BW.Interfaces.DA;
using ModuloCliente.DA.Contexto;

namespace ModuloCliente.DA.Acciones
{
    public class GestionarSolicitudDA : IGestionarSolicitudDA
    {

        private readonly ModuloClienteContexto moduloClienteContexto;

        public GestionarSolicitudDA(ModuloClienteContexto moduloClienteContexto)
        {
            this.moduloClienteContexto = moduloClienteContexto;
        }

        public async Task<bool> CancelarSolicitud(int idSolicitud)
        {
            var solicitudDA = await this.moduloClienteContexto.SolicitudDA.FindAsync(idSolicitud);

            if (solicitudDA == null)
                throw new ErrorCampoExcepcion("Solicitud no encontrada");

            if(solicitudDA.Tipo != TipoSolicitud.CANCELAR_ATENCION)
            {
                solicitudDA.Tipo = TipoSolicitud.CANCELAR_ATENCION;

               var result = await this.moduloClienteContexto.SaveChangesAsync();

                if(result > 0)
                    return true;
            }

            return false;
        }

        public Task<bool> RealizarSolicitud(Solicitud solicitud)
        {
            throw new NotImplementedException();
        }
    }
}
