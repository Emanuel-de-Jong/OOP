using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double PriceExclBTW { get; set; }

        public Product(int _id, string _productName, string _description, double _priceExclBTW)
        {
            Id = _id;
            ProductName = _productName;
            Description = _description;
            PriceExclBTW = _priceExclBTW;
        }
    }
}
