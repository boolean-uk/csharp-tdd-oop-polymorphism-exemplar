using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Book : IProduct
    {
        private string _name;
        private int _price;

        public Book(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public int Price => _price;
        public string Name => _name;
    }
}
