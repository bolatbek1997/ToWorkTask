namespace KendoUIApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uOtbasyJagdai")]
    public partial class uOtbasyJagdai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte IDotbasyjagdai { get; set; }

        public byte? ID { get; set; }

        [StringLength(128)]
        public string NameKZ { get; set; }
    }
}
