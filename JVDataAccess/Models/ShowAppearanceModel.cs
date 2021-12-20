using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace JVDataAccess.Models
{
    public class ShowAppearanceModel
    {
        public string ShowName { get; set; }
        public string Stage { get; set; }
        public string City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastDate { get; set; }
        public int NumberOfShows { get; set; }
        public string Character { get; set; }
        public string FullName { get; set; }

        public int ProductionID { get; set; }

        public ShowAppearanceModel()
        {

        }


        public string NumberOfShowsString => $"{NumberOfShows} föreställning{(NumberOfShows == 1 ? "" : "ar")} spelad{(NumberOfShows == 1 ? "" : "e")}";

        public string LongDateStringSwedish => StartDate.ToString("d MMMM yyyy", CultureInfo.GetCultureInfo("sv-SE"));

    }
}