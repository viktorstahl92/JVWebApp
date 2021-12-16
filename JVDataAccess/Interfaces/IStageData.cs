using JVDataAccess.Models;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public interface IStageData
    {
        Task<StageModel> GetMostPlayedStage(int actorID);
    }
}