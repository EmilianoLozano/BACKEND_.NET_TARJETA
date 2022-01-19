using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarjeta_Credito.Models;

namespace Tarjeta_Credito
{
    public class AplicationDbContext : DbContext
    {

        public  DbSet<TarjetaCredito> Tarjeta_Credito { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {

        }
    }
}
