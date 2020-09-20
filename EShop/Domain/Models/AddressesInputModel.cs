using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Domain.Models
{
    public class AddressesInputModel
    {
        public long ZoneId { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string PostalCode { get; set; }

    }
}
