using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.Data.StatusE;

namespace WebDemo.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public int ShipPhoneNumber { get; set; }
        public OrderStatus Status { get; set; }
        //Relationship
        public List<OrderDetail> OrderDetails { get; set; }
        public AppUser AppUser { get; set; }
    }
}
