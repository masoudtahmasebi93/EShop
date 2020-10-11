using EShop.Domain.Models;
using EShop.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Services
{
    public class CustomerService : ICustomerService
    {
        private IConfiguration _configuration;
        private ICustomerRepository _customerRepository;

        public CustomerService(IConfiguration configuration, ICustomerRepository customerRepository)
        {
            _configuration = configuration;
            _customerRepository = customerRepository;
        }

        public int DeleteCustomerService(CustomerDeleteServiceInputModel data)
        {
            return _customerRepository.DeleteCustomer(data);
        }

        public dynamic InsertCustomerService(CustomerInsertServiceInputModel data)
        {
            return _customerRepository.InsertCustomer(data);
        }

        public dynamic UpdateCustomerService(CustomerUpdateServiceInputModel data)
        {
            return _customerRepository.UpdateCustomer(data);
        }
    }
}
