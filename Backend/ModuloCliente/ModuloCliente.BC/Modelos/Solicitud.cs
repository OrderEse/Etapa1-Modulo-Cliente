using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloCliente.BC.Constantes;

namespace ModuloCliente.BC.Modelos
{
    public class Solicitud
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public string Pedido { get; set; }

        public int MesaId { get; set; }

        public TipoSolicitud Tipo {  get; set; } 

    }
}
