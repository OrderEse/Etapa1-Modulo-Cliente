using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using ModuloCliente.BC.Constantes;
using ModuloCliente.BC.MensajesValidaciones;
namespace ModuloCliente.API.DTOs.Solicitud
{
    public class SolicitudRegistroDTO
    {
        [AllowNull]
        [MaxLength(500, ErrorMessageResourceType = typeof(Mensajes), ErrorMessageResourceName = "MaximoCaracteresPedido")]
        public string Pedido { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensajes), ErrorMessageResourceName = "MesaIdRequerido")]
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Mensajes), ErrorMessageResourceName = "MesaIdRango")]
        public int MesaId { get; set; }

        public TipoSolicitud Tipo { get; set; }


    }
}
