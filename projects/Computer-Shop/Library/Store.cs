using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Store
    {
        public delegate void ProductsEventHandler(string action);
        public event ProductsEventHandler ProductsEvent;

        public string Name { get; set; }
        private List<Product> Products { get; set; }
        public List<Warranty> Warranties { get; set; }


        public Store(string _name)
        {
            Name = _name;
            Products = new List<Product>();
        }


        public Product this [int index]
        {
            get
            {
                return Products[index];
            }
            set
            {
                if (value.GetType() == typeof(Hardware))
                {
                    Hardware objProduct = (Hardware)value;
                    Warranties.Add(objProduct.Warranty);
                    Products[index] = objProduct;
                }
                else
                {
                    Software objProduct = (Software)value;
                    Products[index] = objProduct;
                }
                OnProductsChanged("Product Added!");
            }
        }


        public void AddProduct(Product objProduct)
        {
            Products.Add(objProduct);
            OnProductsChanged("Product Added!");
        }

        public Product GetProduct(string name)
        {
            foreach(Product product in Products){
                if(product.ProductName == name){
                    return product;
                }
            }
            return Products[0];
        }

        public void RemoveProduct(Product objProduct)
        {
            Products.Remove(objProduct);
            OnProductsChanged("Product Removed!");
        }


        public void OnProductsChanged(string action)
        {
            if(ProductsEvent != null)
            {
                ProductsEvent(action);
            }
        }


        public string ProductsToString(){
            var result = "";
            foreach(Product product in Products){
                result += product.ProductName + " | " + product.Description + " | " + Convert.ToString(product.PriceExclBTW) + " euros\n";
            }
            return result;
        }
    }
}
