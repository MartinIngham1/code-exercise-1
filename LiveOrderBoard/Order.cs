using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise
{
    public class Order
    {
        public Order(string userId)
        {
            UserId = userId;
        }

        public string UserId { get; private set; }
    }
}
