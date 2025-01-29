using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloCliente.BC.Enumerados;

namespace ModuloCliente.BC.Modelos
{
    public class Mesa
    {

        public int Id { get; set; }

        public int Numero { get; set; }

        public string Nombre { get; set; }

        public int RestauranteId { get; set; }

        public EstadoMesa Estado { get; set; }

        public bool Activa { get; set; }

        public bool Eliminado { get; set; }
    }
}
