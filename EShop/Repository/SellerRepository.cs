using EShop.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace EShop.Services
{
    public class SellerRepository : ISellerRepository
    {
        private readonly IConfiguration configuration;
        public SellerRepository(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public dynamic InsertSeller(SellerInsertServiceInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    var res = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@item", Newtonsoft.Json.JsonConvert.SerializeObject(data));
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[SellerInsertProcedure]",
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


        public dynamic UpdateSeller(SellerUpdateServiceInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    var res = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@item", Newtonsoft.Json.JsonConvert.SerializeObject(data));
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[SellerUpdateProcedure]",
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

        public int DeleteSeller(SellerDeleteServiceInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                   

                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@Id", data.Id);
                    var reader = con.ExecuteReader(
                   sql: "[dbo].[SellerDeleteProcedure]",
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

        public dynamic test(SellerDeleteServiceInputModel data)
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
        public dynamic Get()
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    con.Open();
                    
                    var reader = con.ExecuteReader(
                   sql: "[dbo].[Sellers]");

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