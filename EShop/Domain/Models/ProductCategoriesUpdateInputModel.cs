﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Domain.Models
{
    public class ProductCategoriesUpdateInputModel
    {
        public int Id { set; get; }
        public int ParentId { set; get; }
        public string Title { set; get; }
        public int ProductTypeId { set; get; }
    }
}
