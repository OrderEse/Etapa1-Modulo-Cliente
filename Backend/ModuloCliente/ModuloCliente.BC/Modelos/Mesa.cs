using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloCliente.BC.Constantes;

namespace ModuloCliente.BC.Modelos
{
    public class Mesa
    {

        public int Id { get; set; }

        public string Numero { get; set; }

        public string Nombre { get; set; }

        public int RestauranteId { get; set; }

        public EstadoMesa Estado { get; set; }


    }
}
