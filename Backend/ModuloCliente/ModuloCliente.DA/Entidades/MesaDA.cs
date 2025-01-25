using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloCliente.BC.Enumerados;

namespace ModuloCliente.DA.Entidades
{
    [Table("MESA")]
    public class MesaDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Numero { get; set; }

        public string Nombre { get; set; }

        [ForeignKey("RestauranteId")]
        public virtual RestauranteDA Restaurante { get; set; }
        public int RestauranteId { get; set; } 

        public EstadoMesa Estado { get; set; }

        public bool Activa { get; set; } 

        public virtual ICollection<SolicitudDA> Solicitudes { get; set; }
    }

}
