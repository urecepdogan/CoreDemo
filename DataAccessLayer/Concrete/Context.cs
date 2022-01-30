using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=OnKayit; integrated security= true; ");

        }

        public DbSet<FiyatTeklif> FiyatTeklifs { get; set; }
        public DbSet<OgrenciBilgi> OgrenciBilgies { get; set; }
        public DbSet<Taksit> Taksits { get; set; }
    }



}
