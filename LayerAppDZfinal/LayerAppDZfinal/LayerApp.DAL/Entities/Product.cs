﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerApp.DAL.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }

        public void Copy(Product from)
        {
            Name = from.Name;
            Price = from.Price;
            CategoryId = from.CategoryId;
        }

    }
}
