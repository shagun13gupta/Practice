﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Category
    {
        public int categoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string description { get; set; }
        public List<Product> Products { get; set; }
    }
}
