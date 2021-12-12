using System;
using System.Collections.Generic;
using System.Text;

namespace JVDataAccess.Models
{
    public class TrackModel
    {
        public string SongName { get; set; }
        public string RoleName { get; set; }
        public int SongOrder { get; set; }

        public string DisplayRole
        {
            get
            {
                string output = RoleName;
                if (output.Contains(','))
                {
                    int place = output.LastIndexOf(',');

                    output = output.Remove(place, 1).Insert(place, " och");
                }

                return output;
            }
        }
    }
}
