﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanli.Core.DTOs
{
    public class ProductDTO : BaseDTO
    {
        public String? Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public int CategoryID { get; set; }

      //  public Category? Category { get; set; }

       // public ProductFeature? ProductFeature { get; set; }
    }
}
