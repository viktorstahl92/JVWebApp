using System;
using System.Collections.Generic;
using System.Text;

namespace JVDataAccess.Models
{
    public class LatestThreeShowsModel
    {
        public string ShowName { get; set; }
        public string RoleName { get; set; }
        public DateTime StartDate { get; set; }
        public int ProductionID { get; set; }
        public string ImageURL { get; set; }

    }
}
