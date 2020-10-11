using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Domain.Models
{
    public class ProductTypeFieldsInputModel
    {
        public string Title { set; get; }
        public string FieldName { set; get; }

        public string DataType { set; get; }
        public int ControlType { set; get; }
        public string DisplayFormat { set; get; }

    }
}
