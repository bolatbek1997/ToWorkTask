namespace KendoUIApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uVisa")]
    public partial class uVisa
    {
        [Key]
        public int IDvisa { get; set; }

        public int? StudTutorID { get; set; }

        [StringLength(128)]
        public string BergenMekeme { get; set; }

        [StringLength(50)]
        public string VisaN { get; set; }

        public DateTime? VisaDate { get; set; }

        public DateTime? VisaDateBegin { get; set; }

        public DateTime? VisaDateEnd { get; set; }

        [StringLength(128)]
        public string VisaTuri { get; set; }

        public byte? VisaMatebeID { get; set; }

        [StringLength(50)]
        public string VisaUzartuAi { get; set; }

        [StringLength(4)]
        public string VisaUzartuJyl { get; set; }
    }
}
