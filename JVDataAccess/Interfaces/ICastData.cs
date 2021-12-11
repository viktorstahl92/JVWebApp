using JVDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public interface ICastData
    {
        Task<List<CastModel>> GetAllActorsInProduction(int pid);

        Task<List<CastModel>> GetAllCreativeInProduction(int pid);
    }
}