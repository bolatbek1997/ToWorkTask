namespace KendoUIApp2.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uStudentTutor")]
    public partial class uStudentTutor
    {
        [Key]
        public int IDStudTutor { get; set; }

        public int? StudentIDTutorID { get; set; }

        public byte? RoleID { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [StringLength(50)]
        public string patronymic { get; set; }

        [StringLength(50)]
        public string firstname_en { get; set; }

        [StringLength(50)]
        public string lastname_en { get; set; }

        [StringLength(50)]
        public string patronymic_en { get; set; }

        public DateTime? BirthDate { get; set; }

        public byte? SexID { get; set; }

        public int? ultID { get; set; }

        public byte? otbasyjagdaiID { get; set; }

        [StringLength(128)]
        public string mail { get; set; }

        [StringLength(128)]
        public string phone { get; set; }

        [StringLength(255)]
        public string adress { get; set; }

        public int? registrationID { get; set; }

        public int? pasportID { get; set; }

        public int? visaID { get; set; }

        public int? groupID { get; set; }

        public byte? OkuTuriID { get; set; }

        public byte? OkumerzimID { get; set; }

        public byte? degreeID { get; set; }

        public bool? SausakTanbasy { get; set; }

        public bool? KanTapsyru { get; set; }

        public bool? MedAnyk086 { get; set; }

        [StringLength(50)]
        public string YktiarHatN { get; set; }

        public DateTime? YktiarHatDateBegin { get; set; }

        public DateTime? YktiarHatDateEnd { get; set; }

        public int? ElineShakyrtuID { get; set; }

        public byte? CourseNumber { get; set; }

        public bool? Active { get; set; }

        public bool? DeleteRec { get; set; }

        public byte? warningV { get; set; }

        public byte? warningP { get; set; }

        public DateTime? DateReg { get; set; }

        [StringLength(255)]
        public string tusindirmeVisa { get; set; }

        [StringLength(255)]
        public string tusindirmePaspor { get; set; }
    }
}
