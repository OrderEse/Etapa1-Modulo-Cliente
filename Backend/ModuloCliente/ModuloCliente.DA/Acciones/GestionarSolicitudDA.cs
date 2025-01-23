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
using ModuloCliente.DA.Entidades;

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
            SolicitudDA solicitudDA = await this.moduloClienteContexto.SolicitudDA.FindAsync(idSolicitud);

            if (solicitudDA == null)
                throw new ErrorCampoExcepcion("Solicitud no encontrada");

            if(solicitudDA.Tipo != TipoSolicitud.CANCELAR_ATENCION)
            {
                solicitudDA.Tipo = TipoSolicitud.CANCELAR_ATENCION;

               var resultado = await this.moduloClienteContexto.SaveChangesAsync();

                if(resultado > 0)
                    return true;
            }

            return false;
        }

        public async Task<bool> RealizarSolicitud(Solicitud solicitud)
        {
            MesaDA mesaDA = await this.moduloClienteContexto.MesaDA.FindAsync(solicitud.MesaId);

            if (mesaDA == null)
                throw new ErrorCampoExcepcion("Mesa no encontrada");

            SolicitudDA solicitudDA = new()
            {
                Pedido = solicitud.Pedido,
                MesaId = mesaDA.Id,
                Tipo = solicitud.Tipo
            };

            await this.moduloClienteContexto.SolicitudDA.AddAsync(solicitudDA);

            var resultado = await this.moduloClienteContexto.SaveChangesAsync();

            return resultado > 0 ;

        }
    }
}
