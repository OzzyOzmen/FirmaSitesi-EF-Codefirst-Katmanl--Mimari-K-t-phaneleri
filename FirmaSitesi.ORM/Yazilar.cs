namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yazilar")]
    public partial class Yazilar
    {
        [Key]
        [Column(Order = 0)]
        public int YazilarID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YaziKategoriID { get; set; }

        [Required]
        [StringLength(50)]
        public string YazilarBaslik { get; set; }

        [Required]
        [StringLength(50)]
        public string YazilarIcerik { get; set; }

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

        public virtual YaziKategori YaziKategori { get; set; }
    }
}
