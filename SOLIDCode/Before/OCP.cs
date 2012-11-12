using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCode.Before
{
    public class Product
    {
        public double Size { get; set; }
        public string Color { get; set; }
    }

    class ProductFilter
    {
        public IEnumerable<Product> ByColor(IEnumerable<Product> source, string color) 
        {
            return source.Where(p => p.Color.Equals(color));
        }
        public IEnumerable<Product> BySize(IEnumerable<Product> source, double size)
        {
            return source.Where(p => p.Size.Equals(size));
        }
        public IEnumerable<Product> ByColorAndSize(IEnumerable<Product> source, string color, double size)
        {
            return source.Where(p => p.Color.Equals(color) && p.Size.Equals(size));
        }
    }
}
