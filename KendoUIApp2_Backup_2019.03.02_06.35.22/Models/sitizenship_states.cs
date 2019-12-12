namespace KendoUIApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sitizenship_states
    {
        [Key]
        public int IDmemleketi { get; set; }

        public int? ID { get; set; }

        [StringLength(128)]
        public string namekz { get; set; }
    }
}
