namespace KendoUIApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class profession
    {
        [Key]
        public int IDmamandik { get; set; }

        public int? professionID { get; set; }

        [StringLength(50)]
        public string shifr { get; set; }

        [StringLength(128)]
        public string professionNameKZ { get; set; }

        public int? facID { get; set; }
    }
}
