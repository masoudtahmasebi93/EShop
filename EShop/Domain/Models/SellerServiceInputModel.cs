using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Domain.Models
{
    public class SellerServiceInputModel
    {
        public string SellerTitle { get; set; }
        public string SellerType { get; set; }
        public string Type { get; set; }
        public string CompanyCode { get; set; }

        public string NationalCode { get; set; }

        public string CompanyName { get; set; }
        public string Lastname { get; set; }

        public string Firstname { get; set; }
        public string Password { get; set; }

        public string Username { get; set; }

        public List<AddressesInputModel> Addresses = new List<AddressesInputModel>();

        public List<ContactsInputModel> Contacts = new List<ContactsInputModel>();

    }
}
