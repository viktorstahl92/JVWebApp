using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;

namespace JVDataAccess.Models
{
    public class ProductionModel
    {
        public int ProductionID { get; set; }
        public string Namn { get; set; }
        public int NumberOfShows { get; set; }
        public string Stage { get; set; }
        public string City { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }

        public string NumberOfShowsString => $"{NumberOfShows} föreställning{(NumberOfShows == 1 ? "" : "ar")} spelad{(NumberOfShows == 1 ? "" : "e")}";

        public string DatePeriod => FirstDate == LastDate ? FirstDate.Date.ToString("d", CultureInfo.GetCultureInfo("sv-SE")) : $"{FirstDate.Date.ToString("d", CultureInfo.GetCultureInfo("sv-SE"))} - {LastDate.Date.ToString("d", CultureInfo.GetCultureInfo("sv-SE"))}";

        public string LongDateStringSwedish => FirstDate.ToString("d MMMM yyyy", CultureInfo.GetCultureInfo("sv-SE"));
    }
}
