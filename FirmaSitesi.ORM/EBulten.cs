namespace FirmaSitesi.ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EBulten")]
    public partial class EBulten
    {
        public int EBultenID { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailAdresi { get; set; }
    }
}
