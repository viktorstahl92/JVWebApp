using JVDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public interface IProductionData
    {
        Task<List<ProductionModel>> GetOtherProductionsOfSameShow(int showID, string showName);
        Task<List<ProductionModel>> GetProductionInfoOnID(int pid);
        Task<List<ProductionModel>> GetProductionInfoOnShowID(int showID);
        Task<List<ProductionModel>> GetRandomProduction();
    }
}