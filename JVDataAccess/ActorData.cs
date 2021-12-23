using JVDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public class ActorData : IActorData
    {
        private readonly ISqlDataAccess _db;

        public ActorData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<ActorModel> GetActor(int ActorID)
        {
            string sql = $"exec SearchActorOnID {ActorID}";

            return _db.LoadSingleItem<ActorModel, dynamic>(sql, new { });

        }

        public Task<List<ActorModel>> GetActors()
        {
            string sql = "select * from Skådespelare order by Skådespelare.LastName";

            return _db.LoadData<ActorModel, dynamic>(sql, new { });

        }

        public Task<List<ActorModel>> SearchActor(string search)
        {
            string sql = $"exec SearchActor '{search}'";

            return _db.LoadData<ActorModel, dynamic>(sql, new { });

        }

       public Task<List<ActorMostPlayedWithModel>> GetActorMostPlayedWith(int actorID)
        {
            string sql = $"exec GetActorPlayedMostWith {actorID}";

            return _db.LoadData<ActorMostPlayedWithModel, dynamic>(sql, new { });
        }

        public Task<List<SearchActorToCompareModel>> GetNumberOfTimesPlayedWithActors(int actorID)
        {
            string sql = $"exec GetNumberOfTimesPlayedWithActors {actorID}";

            return _db.LoadData<SearchActorToCompareModel, dynamic>(sql, new { });
        }

        public Task<List<SearchActorToCompareModel>> GetAllActors ()
        {
            string sql = $"exec GetAllActors";

            return _db.LoadData<SearchActorToCompareModel, dynamic>(sql, new { });
        }

    }
}
