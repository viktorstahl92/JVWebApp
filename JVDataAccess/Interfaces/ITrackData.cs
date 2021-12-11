using JVDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public interface ITrackData
    {
        Task<List<TrackModel>> GetSongsFromProductionToVS(int pid);
    }
}