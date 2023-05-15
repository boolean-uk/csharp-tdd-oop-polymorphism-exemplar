using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Products
{
    public class Drink : IProduct
    {
        private string _name;
        private int _price;

        public Drink(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public int Price => _price;

        public string Name => _name;

    }
}
