using Microsoft.AspNetCore.Mvc;
using ModuloCliente.API.DTOs.Solicitud;
using ModuloCliente.API.Mappers;
using ModuloCliente.BC.Modelos;
using ModuloCliente.BW.Interfaces.BW;

namespace ModuloCliente.API.Controladores
{
    [ApiController]
    [Route("/[controller]")]
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
            var retorno = await this.gestionarSolicitudBW.RealizarSolicitud(solicitud);
            return Created("",  retorno);
        }


        [HttpPut("{idSolicitud}")]
        public async Task<IActionResult> CancelarSolicitud( [FromRoute] SolicitudCancelacionDTO solicitudCancelacionDTO)
        {
            int idSolicitud = solicitudCancelacionDTO.idSolicitud;
            return Ok(await this.gestionarSolicitudBW.CancelarSolicitud(idSolicitud));
        }

    }
}
