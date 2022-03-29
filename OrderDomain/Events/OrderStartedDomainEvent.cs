using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Events
{
    /// <summary>
    /// Used to notify other bounded contexts that the order has 
    /// </summary>
    /// <remarks>Implements INotification that in MediatR Library</remarks>
    public class OrderStartedDomainEvent : INotification
    {
        public string BuyerFirstName { get; set; }
        public string BuyerLastName { get; set; }
        public AggregateModels.OrderModels.Order Order { get; set; }

        public OrderStartedDomainEvent(string buyerFirstName, string buyerLastName, AggregateModels.OrderModels.Order order)
        {
            BuyerFirstName = buyerFirstName;
            BuyerLastName = buyerLastName;
            Order = order;
        }
    }
}
