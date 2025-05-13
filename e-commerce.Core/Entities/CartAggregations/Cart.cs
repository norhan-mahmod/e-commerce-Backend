using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Core.Entities.CartAggregations
{
    public class Cart
    {
        public int Id { get; set; }
        public decimal ShippingPrice { get; set; }
        public List<CartItems> CartItems { get; set; }
    }
}
