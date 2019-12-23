using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Store objStore = new Store("The Good Store");
            objStore.ProductsEvent += OnProductsChanged;


            Person objPerson1 = new Person("Bob Smith", "bsmith@gmail.com", 06123456);

            Warranty objWarranty1 = new Warranty(DateTime.Now, DateTime.Now.AddDays(14), objPerson1);
            Hardware objHardware1 = new Hardware(50, EHardwareType.Keyboard, objWarranty1, 50, 20, 10, 105, "Keyboard 2000", "A cool mecahnical keyboard", 29.99);

            objStore.AddProduct(objHardware1);

            Warranty objWarranty2 = new Warranty(DateTime.Now, DateTime.Now.AddDays(14), objPerson1);
            Hardware objHardware2 = new Hardware(50, EHardwareType.Other, objWarranty2, 50, 20, 10, 20, "Mousepad XXL", "The biggest mousepad in the store!", 81.99);

            objStore.AddProduct(objHardware2);
            Console.WriteLine(objStore.ProductsToString());

            objStore.RemoveProduct(objHardware2);
            Console.WriteLine(objStore.ProductsToString());


            Console.ReadKey();


            void OnProductsChanged(string action)
            {
                Console.WriteLine(action);
            }
        }

        
    }
}
