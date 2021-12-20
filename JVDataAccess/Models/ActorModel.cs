using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JVDataAccess.Models
{
    public class ActorModel
    {
        public int ActorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int TotalShowsPlayed { get; set; }
        public int TotalProductions { get; set; }

        public int AmountWithoutCreative { get; set; }

        public string GetTotalProductions => $"{TotalProductions} {(TotalProductions == 1 ? "produktion" : "produktioner")}";

        public string GetTotalShowsPlayed => $"{TotalShowsPlayed} {(TotalShowsPlayed == 1 ? "föreställning" : "föreställningar")}";

        public string FirstNameGenitiv
        {
            get
            {
                char[] endChar = "sxzSXZ".ToCharArray();

                if (endChar.Any(FirstName.Last().Equals))
                {
                    return FirstName;
                }
                else

                    return $"{FirstName}s";


            }
        }

    }
}
