namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Referanslar")]
    public partial class Referanslar
    {
        [Key]
        [Column(Order = 0)]
        public int ReferansID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReferansKategoriID { get; set; }

        [Required]
        [StringLength(50)]
        public string ReferansAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string ReferansAciklama { get; set; }

        [Required]
        [StringLength(50)]
        public string ReferansLogo { get; set; }

        public virtual ReferansKategori ReferansKategori { get; set; }
    }
}
