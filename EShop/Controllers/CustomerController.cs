using EShop.Domain.Models;
using EShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Controllers
{
        [ApiController]
        [Route("[controller]/[action]")]
        public class CustomerController : ControllerBase
        {

            private readonly ILogger<CustomerController> _logger;

            private readonly ICustomerService _customerService;

            public CustomerController(ILogger<CustomerController> logger,
                ICustomerService customerService)
            {
                _logger = logger;
            _customerService = customerService;
            }

            [HttpPost]
            public IActionResult Insert(CustomerInsertServiceInputModel data)
            {
                return Ok(_customerService.InsertCustomerService(data));
            }

        [HttpPost]
        public IActionResult Update(CustomerUpdateServiceInputModel data)
        {
            return Ok(_customerService.UpdateCustomerService(data));
        }

        [HttpPost]
        public IActionResult Delete(CustomerDeleteServiceInputModel data)
        {
            return Ok(_customerService.DeleteCustomerService(data));
        }


    }
    
}
