using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interfaces
{
    public interface IProduct
    {
        int Price { get; }
        string Name { get; }
    }
}
