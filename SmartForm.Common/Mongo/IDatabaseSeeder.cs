using System.Threading.Tasks;

namespace EShop.Common.Mongo
{
    public interface IDatabaseSeeder
    {
        Task SeedAsync();
    }
}