using JVDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public class ShowAppearanceData : IShowAppearanceData
    {
        private readonly ISqlDataAccess _db;

        public ShowAppearanceData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ShowAppearanceModel>> GetShowAppearances(int ActorID)
        {
            string sql = $"exec GetActorCreditsFromActorID {ActorID}";

            return _db.LoadData<ShowAppearanceModel, dynamic>(sql, new { });

        }

        public Task<List<ShowAppearanceModel>> GetShowAppearancesCreative(int ActorID)
        {
            string sql = $"exec GetCreativeCreditsFromActorID {ActorID}";

            return _db.LoadData<ShowAppearanceModel, dynamic>(sql, new { });

        }

        public Task<List<ShowAppearanceModel>> GetTwoActorsAppearances(int ActorID1, int ActorID2)
        {
            string sql = $"exec GetProductionsTwoActorsHaveMade {ActorID1}, {ActorID2}";

            return _db.LoadData<ShowAppearanceModel, dynamic>(sql, new { });
        }

    }
}
