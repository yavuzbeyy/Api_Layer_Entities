﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanli.Core
{
    public class Category : BaseEntity
    {
        public String? Name { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
