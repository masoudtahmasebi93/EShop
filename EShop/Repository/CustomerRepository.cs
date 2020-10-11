using Dapper;
using EShop.Domain.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IConfiguration configuration;
        public CustomerRepository(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public int DeleteCustomer(CustomerDeleteServiceInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {


                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@Id", data.Id);
                    var reader = con.ExecuteReader(
                   sql: "[dbo].[CustomerDeleteProcedure]",
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

        public dynamic InsertCustomer(CustomerInsertServiceInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                   // var res = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@item", Newtonsoft.Json.JsonConvert.SerializeObject(data));
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[CustomerInsertProcedure]",
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

        public dynamic UpdateCustomer(CustomerUpdateServiceInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    // var res = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@item", Newtonsoft.Json.JsonConvert.SerializeObject(data));
                    var reader = con.Query<dynamic>(
                   sql: "[dbo].[CustomerUpdateProcedure]",
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
