using JVDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public class ProductionImageData : IProductionImageData
    {
        private readonly ISqlDataAccess _db;

        public ProductionImageData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<ProductionImageModel> GetImageOnProductionID(int pid)
        {
            string sql = $"exec GetImageOnProductionID {pid}";

            return _db.LoadSingleItem<ProductionImageModel, dynamic>(sql, new { });
        }

        public Task<ProductionImageModel> GetRandomImage()
        {
            string sql = "exec GetRandomImage";

            return _db.LoadSingleItem<ProductionImageModel, dynamic>(sql, new { });
        }
    }
}
