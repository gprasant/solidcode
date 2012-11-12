using SOLIDCode.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCode.After
{
    public interface IDiscountCalculator 
    {
        decimal CalculateDiscount(IOrder order); 
    }
    
    public interface ITaxStrategy 
    {
        decimal FindTaxAmount(IOrder order); 
    }
}
