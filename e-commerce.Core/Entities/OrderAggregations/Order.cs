using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Core.Entities.OrderAggregations
{
    public class Order : BaseEntity
    {
        public string CustomerId { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TaxPrice { get; set; }
        public decimal ShippingPrice { get; set; }
        public bool IsPaid { get; set; }
        public bool IsDelivered { get; set; }
        public Address ShippingAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
