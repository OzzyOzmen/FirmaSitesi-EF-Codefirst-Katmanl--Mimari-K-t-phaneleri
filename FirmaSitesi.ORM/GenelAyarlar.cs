namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GenelAyarlar")]
    public partial class GenelAyarlar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GenelAyarID { get; set; }

        [Required]
        [StringLength(50)]
        public string WebsiteAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string WebsiteAdresi { get; set; }

        [Required]
        [StringLength(50)]
        public string AdSoyad { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciSifre { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailAdresi { get; set; }

        [Required]
        [StringLength(50)]
        public string WebsiteEmail { get; set; }

        [Required]
        [StringLength(50)]
        public string WebsiteEmailParola { get; set; }

        [Required]
        [StringLength(50)]
        public string SmtpAdres { get; set; }

        public int SmtpPort { get; set; }
    }
}
