using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIApp2.Models
{
    public class ItemsModel
    {
        public List<ModelHuman> productsGrid { get; set; }
        public string fileFormat { get; set; }
        public string headerColor { get; set; }
        public string rowColor { get; set; }
    }
}