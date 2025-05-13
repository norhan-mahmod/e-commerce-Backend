using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Core.Entities.OrderAggregations
{
    public class ProductOrderItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage {  get; set; }
        public ProductOrderItem() { }
        public ProductOrderItem(int Id , string Name , string Image)
        {
            ProductId = Id;
            ProductName = Name;
            ProductImage = Image;
        }
    }
}
