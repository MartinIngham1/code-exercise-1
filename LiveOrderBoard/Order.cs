using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise
{
    public class Order
    {
        public Order(string userId, string orderQuantity, string pricePerKg)
        {
            UserId = userId;
            OrderQuantity = orderQuantity;
            PricePerKg = pricePerKg;
        }

        public string UserId { get; private set; }

        public string OrderQuantity { get; private set; }

        public string PricePerKg { get; private set; }
    }
}
