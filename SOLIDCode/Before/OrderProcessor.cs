using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCode.Before
{
    public interface IOrder
    {
        string Country { get; set; }
        decimal GetItemTotal();
    }
    public class OrderProcessor
    {
        public decimal CalculateTotal(IOrder order)
        {
            decimal itemTotal = order.GetItemTotal();
            decimal discountAmount = DiscountCalculator.CalculateDiscount(order);
            decimal taxAmount = 0.0M;
            taxAmount = FindTaxAmount(order);
     
            decimal total = itemTotal - discountAmount + taxAmount;
            return total;
        }
        
        private decimal FindTaxAmount(IOrder order)
        { // find tax somehow
            return 10.0M;
        }
    }
    public static class DiscountCalculator 
    {
        public static decimal CalculateDiscount(IOrder order)
        {
            return 0.5M;
        }
    }
}
