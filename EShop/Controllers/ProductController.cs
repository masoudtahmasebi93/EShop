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
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger,
            IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpPost]
        public IActionResult GetProductCategories(GetProductsCategoriesInputModel data)
        {
            return Ok(_productService.GetProductCategoriesService(data));
        }

        [HttpPost]
        public IActionResult GetProductTypeFields(GetProductTypeFieldsInputModel data)
        {
            return Ok(_productService.GetProductTypeFieldsService(data));
        }

        [HttpPost]
        public IActionResult DeleteProductCategories(ProductCategoriesDeleteInputModel data)
        {
            return Ok(_productService.DeleteProductCategoriesService(data));
        }

        [HttpPost]
        public IActionResult InsertProductCategories(ProductCategoriesInsertInputModel data)
        {
            return Ok(_productService.InsertProductCategoriesService(data));
        }

        [HttpPost]
        public IActionResult UpdateProductCategories(ProductCategoriesUpdateInputModel data)
        {
            return Ok(_productService.UpdateProductCategoriesService(data));
        }

        [HttpPost]
        public IActionResult DeleteProductType(ProductTypeDeleteInputModel data)
        {
            return Ok(_productService.DeleteProductTypeService(data));
        }

        [HttpPost]
        public IActionResult InsertProductType(ProductTypeInsertInputModel data)
        {
            return Ok(_productService.InsertProductTypeService(data));
        }

        [HttpPost]
        public IActionResult UpdateProductType(ProductTypeUpdateInputModel data)
        {
            return Ok(_productService.UpdateProductTypeService(data));
        }
    }
}
