using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JVDataAccess.Models
{
    public class ActorModel
    {
        public int ActorID { get; set; }
        public string Namn { get; set; }
        public int TotalShowsPlayed { get; set; }
        public int TotalProductions { get; set; }

        public string GetTotalProductions => $"{TotalProductions} {(TotalProductions == 1 ? "produktion" : "produktioner")}";

        public string GetTotalShowsPlayed => $"{TotalShowsPlayed} {(TotalShowsPlayed == 1 ? "föreställning" : "föreställningar")}";

    }
}
