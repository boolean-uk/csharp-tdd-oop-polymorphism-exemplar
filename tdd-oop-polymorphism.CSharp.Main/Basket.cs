using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        private List<IProduct> products = new List<IProduct>();

        public void add(IProduct product)
        {
            this.products.Add(product);
        }


        public int getTotal()
        {
            return products.Sum(x => x.Price);
        }

        public bool isInBasket(string name)
        {
            return products.Any(p => p.Name == name) ? true : false;
        }
    }
}
