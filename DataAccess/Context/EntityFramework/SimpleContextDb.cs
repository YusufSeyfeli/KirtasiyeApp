using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context.EntityFramework
{
    public class SimpleContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.213.173;Database=KirtasiyeApp;User Id=SA; Password=Password1; Integrated Security=false; Encrypt = False;"); //Yusuf'un Database
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<EmailParameter> EmailParameters { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<SiparisUrun> SiparisUruns { get; set; }
        public DbSet<SiparisKirtasiyeUrun> SiparisKirtasiyeUruns { get; set; }
        public DbSet<SiparisKirtasiye> SiparisKirtasiyes { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<MusteriSiparis> MusteriSiparises { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserOperationClaim>()
                .HasOne(x => x.Kullanici)
                .WithMany(y => y.UserOperationClaims)
                .HasForeignKey(z => z.KullaniciId)
                .OnDelete(DeleteBehavior.NoAction);
        
            modelBuilder.Entity<UserOperationClaim>()
                .HasOne(x => x.OperationClaim)
                .WithMany(y => y.UserOperationClaims)
                .HasForeignKey(z => z.OperationClaimId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MusteriSiparis>()
                .HasOne(x => x.Kullanici)
                .WithMany(y => y.MusteriSiparises)
                .HasForeignKey(z => z.KullaniciId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MusteriSiparis>()
                .HasOne(x => x.SiparisUrun)
                .WithOne(y => y.MusteriSiparis)
                .HasForeignKey<MusteriSiparis>(z => z.SiparisId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Urunler>()
                .HasMany(x => x.SiparisUruns) 
                .WithOne(y => y.Urun) 
                .HasForeignKey(z => z.UrunId) 
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Urunler>()
                .HasMany(x => x.SiparisKirtasiyeUruns)
                .WithOne(y => y.Urun)
                .HasForeignKey(z => z.UrunId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SiparisKirtasiye>()
                .HasOne(x => x.SiparisKirtasiyeUrun)
                .WithOne(y => y.SiparisKirtasiye)
                .HasForeignKey<SiparisKirtasiyeUrun>(z => z.SiparisKirtasiyeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Personels)
                .WithOne(y => y.User)
                .HasForeignKey(z => z.InsanId)
                .OnDelete(DeleteBehavior.Cascade);
          
            modelBuilder.Entity<Personel>()
                .HasMany(x => x.SiparisKirtasiyes)
                .WithOne(y => y.Personel)
                .HasForeignKey(z => z.PersonelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Kullanicis)
                .WithOne(y => y.User)
                .HasForeignKey(z => z.InsanId)
                .OnDelete(DeleteBehavior.Cascade);




        }
    }
}
