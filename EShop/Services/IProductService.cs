

using EShop.Domain.Models;

namespace EShop.Services
{
    public interface IProductService 
    {
        dynamic GetProductCategoriesService(GetProductsCategoriesInputModel data);
        dynamic GetProductTypeFieldsService(GetProductTypeFieldsInputModel data);
        int DeleteProductCategoriesService(ProductCategoriesDeleteInputModel data);
        dynamic InsertProductCategoriesService(ProductCategoriesInsertInputModel data);
        dynamic UpdateProductCategoriesService(ProductCategoriesUpdateInputModel data);
        int DeleteProductTypeService(ProductTypeDeleteInputModel data);
        dynamic InsertProductTypeService(ProductTypeInsertInputModel data);
        dynamic UpdateProductTypeService(ProductTypeUpdateInputModel data);


    }
}