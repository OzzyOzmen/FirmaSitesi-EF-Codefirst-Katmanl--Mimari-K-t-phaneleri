namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TumGaleri")]
    public partial class TumGaleri
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GaleriID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string GaleriKategoriAdi { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string GaleriAdi { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string GaleriLogo { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string BuyukResim1 { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string BuyukResim2 { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string BuyukResim3 { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string BuyukResim4 { get; set; }
    }
}
