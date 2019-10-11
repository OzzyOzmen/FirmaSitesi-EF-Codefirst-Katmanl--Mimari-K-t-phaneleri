namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TumReferanslar")]
    public partial class TumReferanslar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReferansID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ReferansKategoriAdi { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ReferansAdi { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ReferansAciklama { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string ReferansLogo { get; set; }
    }
}
