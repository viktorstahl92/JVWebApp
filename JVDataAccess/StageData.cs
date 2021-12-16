using JVDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public class StageData : IStageData
    {
        private readonly ISqlDataAccess _db;

        public StageData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<StageModel> GetMostPlayedStage(int actorID)
        {
            string sql = $"exec GetMostPlayedStage {actorID}";

            return _db.LoadSingleItem<StageModel, dynamic>(sql, new { });

        }

    }
}
