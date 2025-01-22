using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloCliente.DA.Entidades;

namespace ModuloCliente.DA.Contexto
{
    public class ModuloClienteContexto : DbContext
    {

        public ModuloClienteContexto(DbContextOptions options) : base(options) { }

        public DbSet<RestauranteDA> RestauranteDA { get; set; }

        public DbSet<SolicitudDA> SolicitudDA { get; set; }

        public DbSet<MesaDA> MesaDA { get; set; }

    }
}
