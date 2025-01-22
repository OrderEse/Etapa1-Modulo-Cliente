using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCliente.DA.Entidades
{
    [Table("RESTAURANTE")]
    public class RestauranteDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public byte[] ImagenLugar { get; set; }

        public byte[] Logo { get; set; }

        public virtual ICollection<MesaDA> Mesas { get; set; }
    }

}
