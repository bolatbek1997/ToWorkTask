namespace KendoUIApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class studyform
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte IDokumerzim { get; set; }

        public int? ID { get; set; }

        [StringLength(128)]
        public string NameKz { get; set; }
    }
}
