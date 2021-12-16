using JVDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public class ProductionData : IProductionData
    {
        private readonly ISqlDataAccess _db;

        public ProductionData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ProductionModel>> GetProductionInfoOnID(int pid)
        {
            string sql = $"exec GetProductionInfoOnID {pid}";

            return _db.LoadData<ProductionModel, dynamic>(sql, new { });

        }

        public Task<List<ProductionModel>> GetProductionInfoOnShowID(int showID)
        {
            string sql = $"exec GetProductionInfoOnShowID {showID}";

            return _db.LoadData<ProductionModel, dynamic>(sql, new { });

        }

        public Task<List<ProductionModel>> GetRandomProduction()
        {
            string sql = $"exec GetRandomProduction";

            return _db.LoadData<ProductionModel, dynamic>(sql, new { });

        }
    }
}
