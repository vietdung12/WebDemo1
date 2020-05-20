using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.Data.StatusE;

namespace WebDemo.Data.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public Status Status { get; set; }
    }
}
