﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string Email {  get; set; }

        public string CreditNumber { get; set; }
    }
}