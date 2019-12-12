namespace KendoUIApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nationality
    {
        [Key]
        public int IDult { get; set; }

        public int? ID { get; set; }

        [StringLength(128)]
        public string NameKZ { get; set; }
    }
}
