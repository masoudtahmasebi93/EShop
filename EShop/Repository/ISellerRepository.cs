

using EShop.Domain.Models;

namespace EShop.Services
{
    public interface ISellerRepository
    {
         dynamic InsertSeller(SellerServiceInputModel data);
         dynamic Get();
    }
}
