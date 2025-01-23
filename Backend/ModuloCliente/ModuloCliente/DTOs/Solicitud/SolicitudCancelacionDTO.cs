using System.ComponentModel.DataAnnotations;
using ModuloCliente.BC.MensajesValidaciones;

namespace ModuloCliente.API.DTOs.Solicitud
{
    public class SolicitudCancelacionDTO
    {

        [Required(ErrorMessageResourceType = typeof(Mensajes), ErrorMessageResourceName = "SolicitudIdRequerido")]
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Mensajes), ErrorMessageResourceName = "SolicitudIdRango")]
        public int idSolicitud {  get; set; }
    }
}
