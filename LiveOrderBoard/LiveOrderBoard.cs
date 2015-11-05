﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise
{
    public class LiveOrderBoard
    {
        private IDictionary<Guid, Order> orders = new Dictionary<Guid, Order>();

        public Guid RegisterOrder(Order order)
        {
            var orderId = Guid.NewGuid();
            // Assume we can absolutely guarantee a GUID will be unique.
            orders.Add(orderId, order);
            return orderId;
        }

        public void CancelRegisteredOrder(Guid orderId)
        {
            orders.Remove(orderId);
        }

        public IEnumerable<Order> GetOrders()
        {
            return orders.Values;
        }

        public IEnumerable<string> GetSummaryInfoLiveOrders()
        {
            var summaryInfo = new Dictionary<string, decimal>();
            return orders.Values.GroupBy(o => o.PricePerKg).Select(o => string.Format("{0} kg for £{1}", o.Sum(x => x.OrderQuantity), o.First().PricePerKg));
        }
    }
}