using System.Threading.Tasks;

namespace EShop.Common.Mongo
{
    public interface IDatabaseInitializer
    {
        Task InitializeAsync();
    }
}