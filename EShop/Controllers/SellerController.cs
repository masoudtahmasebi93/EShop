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
    [Route("[controller]")]
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

        [HttpGet]
        public IActionResult Insert(SellerServiceInputModel data)
        {
            return Ok(_sellerService.InsertSellerService(data));
        }
    }
}
