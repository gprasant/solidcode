using SOLIDCode.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCode.After
{
    public abstract class ProductFilterSpecification
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> source)
        {
            return ApplyFilter(source);
        }

        protected abstract IEnumerable<Product> ApplyFilter(IEnumerable<Product> source);
    }

    public class ColorFilterSpecification : ProductFilterSpecification
    {
        public string Color { get; set; }

        public ColorFilterSpecification(string color)
        {
            this.Color = color;
        }
        protected override IEnumerable<Product> ApplyFilter(IEnumerable<Product> source)
        {
            return source.Where(p => p.Color.Equals(this.Color));
        }
    }
}
