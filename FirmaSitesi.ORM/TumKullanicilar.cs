namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TumKullanicilar")]
    public partial class TumKullanicilar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KullaniciID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KullaniciYetki { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string KullaniciSifre { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string AdSoyad { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(11)]
        public string Telefon { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
