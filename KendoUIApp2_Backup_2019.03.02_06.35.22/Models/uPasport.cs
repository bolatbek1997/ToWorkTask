namespace KendoUIApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uPasport")]
    public partial class uPasport
    {
        [Key]
        public int IDPasport { get; set; }

        public int? StudTutorID { get; set; }

        [StringLength(50)]
        public string PasportN { get; set; }

        public DateTime? PasportDate { get; set; }

        public DateTime? PasportDateDo { get; set; }

        public int? memleketiID { get; set; }
    }
}
