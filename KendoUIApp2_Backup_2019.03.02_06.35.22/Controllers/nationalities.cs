namespace KendoUIApp2.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nationalities
    {
        [Key]
        public int IDult { get; set; }

        public int? ID { get; set; }

        [StringLength(128)]
        public string NameKZ { get; set; }
    }
}
