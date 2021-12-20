using JVDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public interface IShowAppearanceData
    {
        Task<List<ShowAppearanceModel>> GetShowAppearances(int ActorID);
        Task<List<ShowAppearanceModel>> GetShowAppearancesCreative(int ActorID);
        Task<List<ShowAppearanceModel>> GetTwoActorsAppearances(int ActorID1, int ActorID2);
    }
}