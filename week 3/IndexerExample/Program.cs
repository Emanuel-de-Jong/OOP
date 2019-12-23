using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3 };
            Console.WriteLine(list[0]);


            ProductList objProductList = new ProductList();
            objProductList.Add(new Product { ID = 1, Name = "Fish", Price = 4.95m });
            objProductList.Add(new Product { ID = 2, Name = "Whisky", Price = 4.95m });

            objProductList[0] = new Product { ID = 1, Name = "Fish and Chips", Price = 6.87m };

            Product objProduct1 = objProductList["Fish and Chips"];

            Console.ReadKey();
        }
    }
}
