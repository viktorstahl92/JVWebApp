using JVDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public class ShowData : IShowData
    {
        private readonly ISqlDataAccess _db;

        public ShowData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<ShowModel> GetShowOnID(int sid)
        {
            string sql = $"exec GetShowOnID {sid}";

            return _db.LoadSingleItem<ShowModel, dynamic>(sql, new { });
        }

        public Task<List<ShowModel>> SearchShow(string search)
        {
            string sql = $"exec GetShowsOnName '{search}'";

            return _db.LoadData<ShowModel, dynamic>(sql, new { });

        }

    }
}
