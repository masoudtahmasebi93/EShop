

using EShop.Domain.Models;

namespace EShop.Services
{
    public interface ISellerRepository
    {
        public int InsertSeller(SellerServiceInputModel data);
    }
}