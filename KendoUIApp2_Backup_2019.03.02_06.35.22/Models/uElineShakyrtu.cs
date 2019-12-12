namespace KendoUIApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uElineShakyrtu")]
    public partial class uElineShakyrtu
    {
        [Key]
        public int IDElineShakyrtu { get; set; }

        public int? StudTutorID { get; set; }

        [StringLength(50)]
        public string VisaN { get; set; }

        public DateTime? merzimi { get; set; }
    }
}
