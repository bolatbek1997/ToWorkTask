namespace KendoUIApp2.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uUser")]
    public partial class uUser
    {
        [Key]
        public int IDuser { get; set; }

        public int? TutorID { get; set; }

        [StringLength(128)]
        public string fio { get; set; }

        public bool? Active { get; set; }

        public byte? Role { get; set; }
    }
}
