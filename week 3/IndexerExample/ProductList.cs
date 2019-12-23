using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    public class ProductList
    {
        private List<Product> productItems;

        //indexer
        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < productItems.Count)
                    return productItems[index];
                else
                    throw new IndexOutOfRangeException("Index out of range");
            }

            set
            {
                if (index >= 0 && index < productItems.Count && value != null)
                    productItems[index] = value;
                else if (!(index >= 0 && index < productItems.Count))
                    throw new IndexOutOfRangeException("Index out of range");
                else
                    throw new ArgumentNullException("Argument null exception");

            }
        }
        public Product this[string name]
        {
            get
            {
                foreach (Product objProduct in productItems)
                {
                    if (objProduct.Name == name)
                    {
                        return objProduct;
                    }
                }
                throw new ArgumentNullException("Object not found");
            }

            set
            {
                for (int i=0; i<productItems.Count; i++)
                {
                    if (productItems[i].Name == name)
                    {
                        productItems[i] = value;
                    }
                }
            }
        }

        public ProductList()
        {
            productItems = new List<Product>();
        }

        public void Add(Product objProduct)
        {
            productItems.Add(objProduct);
        }

        public void Remove(Product objProduct)
        {
            productItems.Remove(objProduct);
        }
    }
}
