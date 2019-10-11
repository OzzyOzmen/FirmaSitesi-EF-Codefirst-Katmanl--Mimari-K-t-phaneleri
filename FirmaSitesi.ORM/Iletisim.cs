namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Iletisim")]
    public partial class Iletisim
    {
        public int IletisimID { get; set; }

        [Required]
        [StringLength(50)]
        public string Gonderen { get; set; }

        [Required]
        [StringLength(50)]
        public string IletisimMesaj { get; set; }

        [Required]
        [StringLength(50)]
        public string GonderiTarih { get; set; }

        public bool Okundu { get; set; }
    }
}
