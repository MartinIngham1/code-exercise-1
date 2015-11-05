using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise
{
    public class Order
    {
        public Order(string userId, double orderQuantity, decimal pricePerKg, OrderType orderType)
        {
            if (orderType == OrderType.None)
            {
                throw new ArgumentOutOfRangeException();
            }

            UserId = userId;
            OrderQuantity = orderQuantity;
            PricePerKg = pricePerKg;
            OrderType = orderType;
        }

        public string UserId { get; private set; }

        public double OrderQuantity { get; private set; }

        public decimal PricePerKg { get; private set; }

        public OrderType OrderType { get; set; }

        internal string GetInfo()
        {
            return string.Format("{0} for {1}", OrderQuantity, PricePerKg);
        }
    }
}
