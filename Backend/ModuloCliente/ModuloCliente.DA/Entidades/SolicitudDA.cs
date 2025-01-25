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
    [Table("SOLICITUD")]
    public class SolicitudDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Pedido { get; set; }

        [ForeignKey("MesaId")]
        public virtual MesaDA Mesa { get; set; }
        public int MesaId { get; set; }

        public TipoSolicitud Tipo { get; set; }
    }

}
