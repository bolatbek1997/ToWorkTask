namespace KendoUIApp2.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class groups
    {
        [Key]
        public int IDgroup { get; set; }

        public int? groupID { get; set; }

        public int? mamandikID { get; set; }

        [StringLength(255)]
        public string name { get; set; }
    }
}
