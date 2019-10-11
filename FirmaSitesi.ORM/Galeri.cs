namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Galeri")]
    public partial class Galeri
    {
        [Key]
        [Column(Order = 0)]
        public int GaleriID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GaleriKategoriID { get; set; }

        [Required]
        [StringLength(50)]
        public string GaleriAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string GaleriLogo { get; set; }

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

        public virtual GaleriKategori GaleriKategori { get; set; }
    }
}
