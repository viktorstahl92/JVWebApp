using JVDataAccess.Models;
using System.Threading.Tasks;

namespace JVDataAccess
{
    public interface IProductionImageData
    {
        Task<ProductionImageModel> GetImageOnProductionID(int pid);
        Task<ProductionImageModel> GetRandomImage();
    }
}