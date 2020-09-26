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

        public int InsertSeller(SellerServiceInputModel data)
        {
            using (var con = new SqlConnection(configuration.GetValue<string>("ConnectionString:SQLConnection")))
            {
                try
                {
                    var res = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                    var dbParams = new DynamicParameters();
                    con.Open();
                    dbParams.Add("@item", Newtonsoft.Json.JsonConvert.SerializeObject(data));
                    var reader = con.ExecuteReader(
                   sql: "[dbo].[SellerInsertProcedure]",
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
    }
}