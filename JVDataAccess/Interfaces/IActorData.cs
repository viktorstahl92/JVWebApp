using JVDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public interface IActorData
    {
        Task<ActorModel> GetActor(int ActorID);
        Task<List<ActorMostPlayedWithModel>> GetActorMostPlayedWith(int actorID);
        Task<List<ActorModel>> GetActors();
        Task<List<ActorModel>> SearchActor(string search);
    }
}