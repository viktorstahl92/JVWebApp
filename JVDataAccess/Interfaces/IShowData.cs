using JVDataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public interface IShowData
    {
        Task<List<ShowModel>> SearchShow(string search);

        Task<ShowModel> GetShowOnID(int sid);
    }
}