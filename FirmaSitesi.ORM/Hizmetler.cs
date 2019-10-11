namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hizmetler")]
    public partial class Hizmetler
    {
        [Key]
        public int HizmetID { get; set; }

        [Required]
        [StringLength(50)]
        public string HizmetBaslik { get; set; }

        [Required]
        [StringLength(50)]
        public string HizmetIcerik { get; set; }

        [Required]
        [StringLength(50)]
        public string KucukResim { get; set; }

        [Required]
        [StringLength(50)]
        public string BuyukResim1 { get; set; }

        [Required]
        [StringLength(50)]
        public string BuyukResim2 { get; set; }

        [Required]
        [StringLength(50)]
        public string BuyukResim3 { get; set; }

        [Required]
        [StringLength(50)]
        public string BuyukResim4 { get; set; }
    }
}
