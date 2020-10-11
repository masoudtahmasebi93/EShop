
using EShop.Domain.Models;
using Microsoft.Extensions.Configuration;

namespace EShop.Services
{
    public class ProductService : IProductService
    {

        private IConfiguration _configuration;
        private IProductRepository _ProductRepository;
       

        public ProductService(IConfiguration configuration, IProductRepository productRepository)
        {
            _configuration = configuration;
            _ProductRepository= productRepository;
        }

        public int DeleteProductCategoriesService(ProductCategoriesDeleteInputModel data)
        {
            return _ProductRepository.DeleteProductCategories(data);
        }

        public int DeleteProductTypeService(ProductTypeDeleteInputModel data)
        {
            return _ProductRepository.DeleteProductType(data);
        }

        public dynamic GetProductCategoriesService(GetProductsCategoriesInputModel data)
        {
            return _ProductRepository.GetProductCategories(data);
        }

        public dynamic GetProductTypeFieldsService(GetProductTypeFieldsInputModel data)
        {
            return _ProductRepository.GetProductTypeFields(data);
        }

        public dynamic InsertProductCategoriesService(ProductCategoriesInsertInputModel data)
        {
            return _ProductRepository.InsertProductCategories(data);
        }

        public dynamic InsertProductTypeService(ProductTypeInsertInputModel data)
        {
            return _ProductRepository.InsertProductType(data);
        }

        public dynamic UpdateProductCategoriesService(ProductCategoriesUpdateInputModel data)
        {
            return _ProductRepository.UpdateProductCategories(data);
        }

        public dynamic UpdateProductTypeService(ProductTypeUpdateInputModel data)
        {
            return _ProductRepository.UpdateProductType(data);
        }
    }
}