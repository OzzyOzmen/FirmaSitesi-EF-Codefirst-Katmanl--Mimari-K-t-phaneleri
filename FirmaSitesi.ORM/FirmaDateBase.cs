namespace FirmaSitesi.ORM
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FirmaDateBase : DbContext
    {
        public FirmaDateBase()
            : base("name=FirmaDateBase")
        {
        }

        public virtual DbSet<EBulten> EBulten { get; set; }
        public virtual DbSet<Galeri> Galeri { get; set; }
        public virtual DbSet<GaleriKategori> GaleriKategori { get; set; }
        public virtual DbSet<GenelAyarlar> GenelAyarlar { get; set; }
        public virtual DbSet<Hizmetler> Hizmetler { get; set; }
        public virtual DbSet<Iletisim> Iletisim { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciYetki> KullaniciYetki { get; set; }
        public virtual DbSet<ReferansKategori> ReferansKategori { get; set; }
        public virtual DbSet<Referanslar> Referanslar { get; set; }
        public virtual DbSet<Sayfalar> Sayfalar { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tedarikci> Tedarikci { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<UrunKategori> UrunKategori { get; set; }
        public virtual DbSet<YaziKategori> YaziKategori { get; set; }
        public virtual DbSet<Yazilar> Yazilar { get; set; }
        public virtual DbSet<TumGaleri> TumGaleri { get; set; }
        public virtual DbSet<TumKullanicilar> TumKullanicilar { get; set; }
        public virtual DbSet<TumReferanslar> TumReferanslar { get; set; }
        public virtual DbSet<TumUrunler> TumUrunler { get; set; }
        public virtual DbSet<Tumyazilar> Tumyazilar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GaleriKategori>()
                .HasMany(e => e.Galeri)
                .WithRequired(e => e.GaleriKategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.Telefon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KullaniciYetki>()
                .HasMany(e => e.Kullanici)
                .WithRequired(e => e.KullaniciYetki)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReferansKategori>()
                .HasMany(e => e.Referanslar)
                .WithRequired(e => e.ReferansKategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tedarikci>()
                .HasMany(e => e.Urun)
                .WithRequired(e => e.Tedarikci)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .Property(e => e.UrunFiyati)
                .HasPrecision(18, 0);

            modelBuilder.Entity<UrunKategori>()
                .HasMany(e => e.Urun)
                .WithRequired(e => e.UrunKategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YaziKategori>()
                .HasMany(e => e.Yazilar)
                .WithRequired(e => e.YaziKategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TumKullanicilar>()
                .Property(e => e.Telefon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TumUrunler>()
                .Property(e => e.UrunFiyati)
                .HasPrecision(18, 0);
        }
    }
}
