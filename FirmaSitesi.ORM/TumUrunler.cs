namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TumUrunler")]
    public partial class TumUrunler
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UrunID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string UrunKategoriAdi { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string UrunAdi { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short UrunStokAdeti { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal UrunFiyati { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string TedarikciAdi { get; set; }
    }
}
