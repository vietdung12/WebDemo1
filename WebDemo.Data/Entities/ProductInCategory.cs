using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Data.Entities
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        //Relationship
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
