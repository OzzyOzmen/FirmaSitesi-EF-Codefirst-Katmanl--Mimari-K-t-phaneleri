namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [Key]
        [Column(Order = 0)]
        public int KullaniciID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KullaniciYetkiID { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciSifre { get; set; }

        [Required]
        [StringLength(50)]
        public string AdSoyad { get; set; }

        [Required]
        [StringLength(11)]
        public string Telefon { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public virtual KullaniciYetki KullaniciYetki { get; set; }
    }
}
