﻿using EShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Services
{
    public interface ICustomerService
    {
        dynamic InsertCustomerService(CustomerInsertServiceInputModel data);
        dynamic UpdateCustomerService(CustomerUpdateServiceInputModel data);
        int DeleteCustomerService(CustomerDeleteServiceInputModel data);
    }
}
