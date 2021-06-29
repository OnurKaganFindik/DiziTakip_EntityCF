using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziTakip_EntityCF.Models
{

    public class DiziTakipContext : DbContext
    {
        public DbSet<Dizi> Diziler { get; set; }
    }
}
