using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop.Domain.Models;
using EShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EShop.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SellerController : ControllerBase
    {

        private readonly ILogger<SellerController> _logger;

        private readonly ISellerService _sellerService;

        public SellerController(ILogger<SellerController> logger,
            ISellerService sellerService)
        {
            _logger = logger;
            _sellerService = sellerService;
        }

        [HttpPost]
        public IActionResult Insert(SellerInsertServiceInputModel data)
        {
            return Ok(_sellerService.InsertSellerService(data));
        }

        [HttpPost]
        public IActionResult Update(SellerUpdateServiceInputModel data)
        {
            return Ok(_sellerService.UpdateSellerService(data));
        }

        [HttpPost]
        public IActionResult Delete(SellerDeleteServiceInputModel data)
        {
            return Ok(_sellerService.DeleteSellerService(data));
        }

        [HttpGet]
        public IActionResult test(SellerDeleteServiceInputModel data)
        {
            return Ok(_sellerService.test(data));
        }

        //http://localhost:7186/Seller/get
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_sellerService.Get());
        }

    }
}
