using System;
using System.Collections.Generic;
using System.Text;

namespace JVDataAccess.Models
{
    public class StageModel
    {
        public int TotalPlayed { get; set; }
        public string Stage { get; set; }
        public string City { get; set; }

        public string TotalPlayedString => $"{TotalPlayed} gång{(TotalPlayed == 1 ? "" : "er")}";
    }
}
