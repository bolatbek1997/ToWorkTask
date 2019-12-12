namespace KendoUIApp2.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uRegistration")]
    public partial class uRegistration
    {
        [Key]
        public int IDregistration { get; set; }

        [StringLength(255)]
        public string living_adress { get; set; }

        public int? cityID { get; set; }

        [StringLength(50)]
        public string registrationN { get; set; }

        public DateTime? registrationDate { get; set; }

        public DateTime? registrationDateDo { get; set; }

        public int? StudTutorID { get; set; }
    }
}
