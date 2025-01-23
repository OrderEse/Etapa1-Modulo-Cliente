using Microsoft.AspNetCore.Mvc;
using ModuloCliente.API.DTOs.Solicitud;
using ModuloCliente.API.Mappers;
using ModuloCliente.BC.Modelos;
using ModuloCliente.BW.Interfaces.BW;

namespace ModuloCliente.API.Controladores
{
    public class SolicitudController : ControllerBase
    {

        private readonly IGestionarSolicitudBW gestionarSolicitudBW;

        public SolicitudController(IGestionarSolicitudBW gestionarSolicitudBW)
        {
            this.gestionarSolicitudBW = gestionarSolicitudBW;
        }

        [HttpPost]
        public async Task<IActionResult> RealizarSolicitud( [FromBody] SolicitudRegistroDTO solicitudRegistroDTO)
        {
            Solicitud solicitud = SolicitudDTOMapper.ConvertirSolicitudRegistroDTOASolicitud(solicitudRegistroDTO);
            return Created("",  this.gestionarSolicitudBW.RealizarSolicitud(solicitud));
        }


        [HttpPut("{idSolicitud}")]
        public async Task<IActionResult> CancelarSolicitud( [FromRoute] SolicitudCancelacionDTO solicitudCancelacionDTO)
        {
            int idSolicitud = solicitudCancelacionDTO.idSolicitud;
            return Ok(await this.gestionarSolicitudBW.CancelarSolicitud(idSolicitud));
        }

    }
}
