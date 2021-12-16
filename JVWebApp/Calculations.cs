using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JVWebApp
{
    public static class Calculations
    {

        public static string GetPercentage (int Lower, int Higher)
        {
            int totalPercentage = (int)((double)Lower / Higher * 100);

            return $"{totalPercentage}%";
        }


    }
}
