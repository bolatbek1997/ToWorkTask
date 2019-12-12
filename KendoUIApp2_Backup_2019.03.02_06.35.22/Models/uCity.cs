namespace KendoUIApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uCity")]
    public partial class uCity
    {
        [Key]
        public int IDcity { get; set; }

        [StringLength(128)]
        public string NameKZ { get; set; }
    }
}
