using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using KendoUIApp2.Models;
using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Txt;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Utilities;

using Spire.Doc;
using Spire.Doc.Documents;
using System.IO;

namespace KendoUIApp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TestWord()
        {
            Document document = new Document();
            //document.LoadFromStream(new MemoryStream(dosyaBytes))

            return null;
        }

        public ActionResult Remote_Binding_Orders_Read([DataSourceRequest]DataSourceRequest request)
        {
            var db = new VisaDBContext();

            // var list= db.uStudentTutors.Where(x=> x.pasportID != null).ToList();
            var list2 = db.uStudentTutors.
                Select(z => new ModelHuman()
                {
                    id = z.IDStudTutor,
                    birthDate = z.BirthDate,
                    FIO = z.lastname + " " + z.firstname + " " + z.patronymic,
                    FIOpasport = z.lastname_en + " " + z.firstname_en + " " + z.patronymic_en,
                    pol = z.SexID,
                    merried = z.otbasyjagdaiID,
                    nationality = db.nationalities.Where(x => x.IDult == z.ultID).FirstOrDefault().NameKZ,
                    pasportEndOfDate = db.uPasports.FirstOrDefault(x => x.IDPasport == z.pasportID).PasportDateDo ?? null,
                    visaEndOfDate = db.uVisas.FirstOrDefault(x => x.IDvisa == z.visaID).VisaDateEnd ?? null,
                    //countDayVisaEnd = (db.uVisas.FirstOrDefault(x => x.IDvisa == z.visaID).VisaDateEnd-DateTime.Today).Value.Days ,
                    //countDayPasportEnd = (db.uPasports.FirstOrDefault(x => x.IDPasport == z.pasportID).PasportDateDo- DateTime.Today).Value.Days


                }).ToList();
            var list = list2.Where(x => x.pasportEndOfDate != null || x.visaEndOfDate != null).OrderBy(x => x.visaEndOfDate).ToList();

            //foreach (var item in list2)
            //{
            //    DateTime? time = null;
            //    if (db.uPasports.Where(x => x.StudTutorID == item.id).FirstOrDefault() != null)
            //    {
            //        time = db.uPasports.Where(x => x.StudTutorID == item.id).FirstOrDefault().PasportDateDo;
            //    }

            //    DateTime? today = DateTime.UtcNow;
            //    if (time != null)
            //    {
            //        TimeSpan timeSpan = time.GetValueOrDefault() - today.GetValueOrDefault();
            //        item.countDayPasportEnd = timeSpan.Days;
            //    }
            //    else item.countDayPasportEnd = null;

            //    DateTime? time2 = null;
            //    if (db.uVisas.Where(x => x.StudTutorID == item.id).FirstOrDefault() != null)
            //        time2 = db.uVisas.Where(x => x.StudTutorID == item.id).FirstOrDefault().VisaDateEnd;
            //    if (time != null)
            //    {
            //        TimeSpan timeSpan = time2.GetValueOrDefault() - today.GetValueOrDefault();
            //        item.countDayPasportEnd = timeSpan.Days;
            //    }
            //    else item.countDayPasportEnd = null;
            //}

            return Json(list.ToDataSourceResult(request));
            //return View();
        }

        public ActionResult StudentInfo(int id)
        {
            var db =  new VisaDBContext();
            var item = db.uStudentTutors.Where(x => x.IDStudTutor == id).Select(x => new infoHuman()
            {
                adress = x.adress,
                email = x.mail,
                phoneNumber = x.phone,
                infoMessege = x.tusindirmeVisa
            }).ToList();
            //return Json(item);
            ViewBag.item = item;
            return PartialView();
        }

        [HttpPost]
        public ActionResult GenerateFile(ItemsModel productsGrid, string fileFormat, string headerColor, string rowColor)
        {
            IWorkbookFormatProvider fileFormatProvider = null;
            Workbook document = GenerateWorkbook(productsGrid, headerColor, rowColor);
            string mimeType = String.Empty;
            string fileDownloadName = "{0}.{1}";

            fileDownloadName = String.Format(fileDownloadName, "SampleDocument", fileFormat);

            switch (fileFormat)
            {
                case "xlsx":
                    fileFormatProvider = new XlsxFormatProvider();
                    mimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;
                case "csv":
                    fileFormatProvider = new CsvFormatProvider();
                    mimeType = "text/csv";
                    break;
                case "txt":
                    fileFormatProvider = new TxtFormatProvider();
                    mimeType = "text/plain";
                    break;
                default:
                    fileFormatProvider = new TxtFormatProvider();
                    mimeType = "text/plain";
                    break;
            }

            byte[] renderedBytes = null;

            using (MemoryStream ms = new MemoryStream())
            {
                fileFormatProvider.Export(document, ms);
                renderedBytes = ms.ToArray();
            }

            return File(renderedBytes, mimeType, fileDownloadName);
        }
    }
}
