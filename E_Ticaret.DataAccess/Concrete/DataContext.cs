using E_Ticaret.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.Concrete
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=MERT; Database=ETicaret; User Id=sa; Password =123");
            
        }

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Admin> admins { get; set; }
        public DbSet<Cari> caris { get; set; }
        public DbSet<Departman> departmans { get; set; }
        public DbSet<Fatura> faturas { get; set; }
        public DbSet<FaturaKalem> faturaKalems { get; set; }
        public DbSet<GiderSiniflari> giderSiniflaris { get; set; }
        public DbSet<Katagori> katagoris { get; set; }
        public DbSet<Personel> personels { get; set; }
        public DbSet<SatisHareketleri> satisHareketleris { get; set; }
        public DbSet<Urun> uruns { get; set; }

    }
}
