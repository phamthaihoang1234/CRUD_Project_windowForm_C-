using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagment
{
    internal class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }
        public string CreateDate { get; set; }
        public int Quantity { get; set; }
        public string Discontinued { get; set; }

    }
}
