namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urun")]
    public partial class Urun
    {
        [Key]
        [Column(Order = 0)]
        public int UrunID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UrunKategoriID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TedarikciID { get; set; }

        [Required]
        [StringLength(50)]
        public string UrunAdi { get; set; }

        public short UrunStokAdeti { get; set; }

        public decimal UrunFiyati { get; set; }

        public virtual Tedarikci Tedarikci { get; set; }

        public virtual UrunKategori UrunKategori { get; set; }
    }
}
