using Dapper;
using EShop.Domain.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EShop.Services
{
    public class ProductRepository : IProductRepository
    {

        private readonly IConfiguration configuration;
        public ProductRepository(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public int DeleteProductCategories(ProductCategoriesDeleteInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@Id", data.Id);
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[ProductCategoriesDeleteProcedure]",
                   param: dbParams,
                   commandType: CommandType.StoredProcedure);

                    return 1;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }

        }

        public int DeleteProductType(ProductTypeDeleteInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@Id", data.Id);
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[ProductTypeDeleteProcedure]",
                   param: dbParams,
                   commandType: CommandType.StoredProcedure);

                    return 1;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }

        }

        public dynamic GetProductCategories(GetProductsCategoriesInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@Id",data.Id);
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[GetProductCategoriesById]",
                   param: dbParams,
                   commandType: CommandType.StoredProcedure);

                    return reader;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }


        }

        public dynamic GetProductTypeFields(GetProductTypeFieldsInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@Id", data.Id);
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[GetProductTypeFieldsById]",
                   param: dbParams,
                   commandType: CommandType.StoredProcedure);

                    return reader;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public dynamic InsertProductCategories(ProductCategoriesInsertInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@item", Newtonsoft.Json.JsonConvert.SerializeObject(data));
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[ProductCategoriesInsertProcedure]",
                   param: dbParams,
                   commandType: CommandType.StoredProcedure);

                    return reader;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }

        }

        public dynamic InsertProductType(ProductTypeInsertInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@item", Newtonsoft.Json.JsonConvert.SerializeObject(data));
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[ProductTypeInsertProcedure]",
                   param: dbParams,
                   commandType: CommandType.StoredProcedure);

                    return reader;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public dynamic UpdateProductCategories(ProductCategoriesUpdateInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@item", Newtonsoft.Json.JsonConvert.SerializeObject(data));
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[ProductCategoriesUpdateProcedure]",
                   param: dbParams,
                   commandType: CommandType.StoredProcedure);

                    return reader;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public dynamic UpdateProductType(ProductTypeUpdateInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@item", Newtonsoft.Json.JsonConvert.SerializeObject(data));
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[ProductTypeUpdateProcedure]",
                   param: dbParams,
                   commandType: CommandType.StoredProcedure);

                    return reader;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}