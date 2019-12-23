using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExample
{
    public class Product
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Product(int _id, string _name)
        {
            id = _id;
            name = _name;
        }
        public Product(int _id)
        {
            id = _id;
        }
        public Product(string _name)
        {
            name = _name;
        }
        public Product(){}
    }
}
