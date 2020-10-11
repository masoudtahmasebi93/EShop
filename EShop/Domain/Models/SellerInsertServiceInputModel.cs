using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Domain.Models
{
    public class SellerInsertServiceInputModel
    {
        public string SellerTitle { get; set; }
        public int SellerType { get; set; }
        public int PersonType { get; set; }
        public string CompanyCode { get; set; }
        public string NationalCode { get; set; }
        public string CompanyName { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public List<AddressesInputModel> Addresses { get; set; }
        public List<ContactsInputModel> Contacts { get; set; }
    }
}
