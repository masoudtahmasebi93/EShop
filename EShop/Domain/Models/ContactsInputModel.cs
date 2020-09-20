using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Domain.Models
{
    public class ContactsInputModel
    {

        public long ContactTypeId { get; set; }
        public string Title { get; set; }
        public string Value { set; get; }
    }
}
