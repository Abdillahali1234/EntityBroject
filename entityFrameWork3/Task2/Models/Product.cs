﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    internal class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity {  get; set; }
        public string Description { get; set; }
    }
}