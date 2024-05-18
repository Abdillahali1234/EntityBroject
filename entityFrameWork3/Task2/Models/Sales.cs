using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    internal class Sales
    {
        public int SalesId { get; set; }

        public int CustomerId { get; set; }
       
        public DateTime Date { get; set; }

        public int ProductId { get; set; }

        public int StoreId { get; set; }


        public Customer Customer { get; set; }

        public Product Product { get; set; }

        public Store Store { get; set; }
    }
}
