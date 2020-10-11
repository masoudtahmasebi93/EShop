using EShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Services
{
    public interface ISellerService
    {
        dynamic InsertSellerService(SellerInsertServiceInputModel data);

        dynamic UpdateSellerService(SellerUpdateServiceInputModel data);

        int DeleteSellerService(SellerDeleteServiceInputModel data);

        dynamic Get();

        dynamic test(SellerDeleteServiceInputModel data);
    }
}
