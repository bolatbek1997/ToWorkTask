namespace KendoUIApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uVisaMatebe")]
    public partial class uVisaMatebe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte IDVisaMatebe { get; set; }

        [StringLength(128)]
        public string NameKZ { get; set; }
    }
}
