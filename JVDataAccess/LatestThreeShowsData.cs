using JVDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public class LatestThreeShowsData : ILatestThreeShowsData
    {
        private readonly ISqlDataAccess _db;

        public LatestThreeShowsData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<LatestThreeShowsModel>> GetProductionInfoOnID(int actorID)
        {
            string sql = $"exec GetThreeLatestShows {actorID}";

            return _db.LoadData<LatestThreeShowsModel, dynamic>(sql, new { });

        }

    }
}
