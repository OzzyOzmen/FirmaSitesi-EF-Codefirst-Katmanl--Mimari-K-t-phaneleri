namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sayfalar")]
    public partial class Sayfalar
    {
        [Key]
        public int SayfaID { get; set; }

        [Required]
        [StringLength(50)]
        public string SayfaBaslik { get; set; }

        [Required]
        public string SayfaIcerik { get; set; }

        [Required]
        [StringLength(50)]
        public string KucukResim { get; set; }

        [Required]
        [StringLength(50)]
        public string BuyukResim { get; set; }

        [Required]
        [StringLength(50)]
        public string SayfaUrl { get; set; }
    }
}
