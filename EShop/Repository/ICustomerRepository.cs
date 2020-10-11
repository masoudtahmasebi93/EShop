using EShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Repository
{
    public interface ICustomerRepository
    {
        dynamic InsertCustomer(CustomerInsertServiceInputModel data);
       
        dynamic UpdateCustomer(CustomerUpdateServiceInputModel data);
        int DeleteCustomer(CustomerDeleteServiceInputModel data);
    }
}
