namespace KendoUIApp2.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class faculties
    {
        [Key]
        public int IDfac { get; set; }

        public int? FacultyID { get; set; }

        [StringLength(128)]
        public string facultyNameKZ { get; set; }
    }
}
