using JVDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public class CastData : ICastData
    {
        private readonly ISqlDataAccess _db;

        public CastData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CastModel>> GetAllActorsInProduction(int pid)
        {
            string sql = $"exec GetAllActorsInProduction {pid}";

            return _db.LoadData<CastModel, dynamic>(sql, new { });

        }

        public Task<List<CastModel>> GetAllCreativeInProduction(int pid)
        {
            string sql = $"exec GetAllCreativeInProduction {pid}";

            return _db.LoadData<CastModel, dynamic>(sql, new { });
        }
    }
}
