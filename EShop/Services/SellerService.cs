using EShop.Domain.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Services
{
    public class SellerService : ISellerService
    {
        private IConfiguration _configuration;
        private ISellerRepository _sellerRepository;

        public SellerService(IConfiguration configuration, ISellerRepository sellerRepository)
        {
            _configuration = configuration;
            _sellerRepository = sellerRepository;
        }

        public dynamic Get()
        {
            return _sellerRepository.Get();
        }

        public dynamic InsertSellerService(SellerServiceInputModel data)
        {
            return _sellerRepository.InsertSeller(data);
        }
    }
}
