using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Domain.Models
{
    public class ProductTypeInsertInputModel
    {
        public List<ProductTypeFieldsInputModel> ProductTypeFields { set; get; }

        public string Title { set; get; }
    }
}
