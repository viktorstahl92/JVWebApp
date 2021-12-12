using JVDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public interface ILatestThreeShowsData
    {
        Task<List<LatestThreeShowsModel>> GetProductionInfoOnID(int actorID);
    }
}