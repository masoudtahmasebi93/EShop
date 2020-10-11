

using EShop.Domain.Models;
using Microsoft.SqlServer.Server;

namespace EShop.Services
{
    public interface IProductRepository 
    {
        dynamic GetProductCategories(GetProductsCategoriesInputModel data);
        dynamic GetProductTypeFields(GetProductTypeFieldsInputModel data);
        int DeleteProductCategories(ProductCategoriesDeleteInputModel data);

        dynamic InsertProductCategories(ProductCategoriesInsertInputModel data);

        dynamic UpdateProductCategories(ProductCategoriesUpdateInputModel data);

        int DeleteProductType(ProductTypeDeleteInputModel data);

        dynamic InsertProductType(ProductTypeInsertInputModel data);
        
        dynamic UpdateProductType(ProductTypeUpdateInputModel data);


    }
}