using JVDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public class TrackData : ITrackData
    {
        private readonly ISqlDataAccess _db;

        public TrackData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<TrackModel>> GetSongsFromProductionToVS(int pid)
        {
            string sql = $"exec GetSongsFromProductionToVS {pid}";

            return _db.LoadData<TrackModel, dynamic>(sql, new { });
        }

    }
}
