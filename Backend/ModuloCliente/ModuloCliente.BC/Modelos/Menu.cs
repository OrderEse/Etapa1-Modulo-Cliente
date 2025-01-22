using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCliente.BC.Modelos
{
    public class Menu
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int RestauranteId { get; set; }

        public byte[] Archivo { get; set; }

    }
}
