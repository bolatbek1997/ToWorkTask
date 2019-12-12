namespace KendoUIApp2.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uOkuTuri")]
    public partial class uOkuTuri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte IDOkuTuri { get; set; }

        [StringLength(128)]
        public string NameKZ { get; set; }
    }
}
