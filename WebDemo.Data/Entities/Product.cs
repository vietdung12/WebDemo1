using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.Data.StatusE;

namespace WebDemo.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Producer { get; set; }
        public decimal Price { get; set; }       
        public int Stock { get; set; }
        public string Tag { get; set; }
        public int? ViewCount { get; set; }
        public int? OrdersCount { get; set; }
        public DateTime DateCreated { get; set; }
        public Status Status { get; set; }
        //Relationship
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
