using ModuloCliente.API.DTOs.Solicitud;
using ModuloCliente.BC.Modelos;

namespace ModuloCliente.API.Mappers
{
    public class SolicitudDTOMapper
    {

        public static Solicitud ConvertirSolicitudRegistroDTOASolicitud(SolicitudRegistroDTO solicitudRegistroDTO)
        {
            return new Solicitud()
            {
                MesaId = solicitudRegistroDTO.MesaId,
                Pedido = solicitudRegistroDTO.Pedido,
                Tipo = solicitudRegistroDTO.Tipo
            };
        }


        

    }
}
