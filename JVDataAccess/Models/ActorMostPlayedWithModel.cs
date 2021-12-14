using System;
using System.Collections.Generic;
using System.Text;

namespace JVDataAccess.Models
{
    public class ActorMostPlayedWithModel
    {
        public string ActorName { get; set; }
        public int NumberOfProductions { get; set; }
        public int TimesPlayedWith { get; set; }
        public int ActorID { get; set; }
    }
}
