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

        [HttpGet]
        public IActionResult Insert(SellerServiceInputModel data)
        {
            return Ok(_sellerService.InsertSellerService(data));
        }

        [HttpGet]
        public IActionResult test()
        {
            return Ok(_sellerService.test());
        }

        //http://localhost:7186/Seller/get
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_sellerService.Get());
        }

        // http://localhost:7186/Seller/Edit/5
        [HttpGet("{id}")]
        public IActionResult Edit(long id)
        {
            return Ok("" + id);
        }

        //http://localhost:7186/Seller/mamad
        [HttpGet]
        public IActionResult Mamad()
        {
            return Ok("Salam Mamad");
        }
        //http://localhost:7186/Seller/joonom/joonom
        [HttpGet("joonom")]
        public IActionResult Joonom()
        {
            return Ok("Salam joonom");
        }

    }
}
