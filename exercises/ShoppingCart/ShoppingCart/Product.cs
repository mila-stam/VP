using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

        public Product() { }
        public Product(string name, string category, string price)
        {
            Name = name;
            Price = Convert.ToInt32(price);
            Category = category;
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
