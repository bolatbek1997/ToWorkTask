using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIApp2.Models
{
    public class ModelHuman
    {

        public int id { get; set; }
        public string FIO { get; set; }
        public string FIOpasport { get; set; }
        public DateTime? birthDate { get; set; }
        public byte? merried { get; set; }
        public string nationality { get; set; }
        public byte? pol { get; set; }
        public DateTime? visaEndOfDate { get; set; }
        public int? countDayVisaEnd { get; set; }
        public DateTime? pasportEndOfDate { get; set; }
        public int countDayPasportEnd { get; set; }
        public int visaId { get; set; }
        public int? pasportId { get; set; }
    }
    public class infoHuman
    {
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public string infoMessege { get; set; }

    }

}