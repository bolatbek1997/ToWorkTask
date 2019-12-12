namespace KendoUIApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uKetkender")]
    public partial class uKetkender
    {
        [Key]
        public int IDdeactive { get; set; }

        [StringLength(20)]
        public string buirykN { get; set; }

        public DateTime? dateBuiryk { get; set; }

        public byte? sebepID { get; set; }

        public int? StudTutorID { get; set; }

        [StringLength(255)]
        public string sipattama { get; set; }
    }
}
