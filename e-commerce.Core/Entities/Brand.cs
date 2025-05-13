using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Core.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public string Image {  get; set; }
        public List<Product> Products { get; set; }
    }
}
