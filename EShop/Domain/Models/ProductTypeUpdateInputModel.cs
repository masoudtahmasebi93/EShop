using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Domain.Models
{
    public class ProductTypeUpdateInputModel
    {
        public int Id { set; get; }

        public List<ProductTypeFieldsInputModel> ProductTypeFields { set; get; }

        public string Title { set; get; }
    }
}
