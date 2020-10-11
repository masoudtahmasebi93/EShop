

using EShop.Domain.Models;

namespace EShop.Services
{
    public interface ISellerRepository
    {
        dynamic InsertSeller(SellerInsertServiceInputModel data);
        dynamic UpdateSeller(SellerUpdateServiceInputModel data);
        int DeleteSeller(SellerDeleteServiceInputModel data);
        dynamic Get();
        dynamic test(SellerDeleteServiceInputModel data);
    }
}
