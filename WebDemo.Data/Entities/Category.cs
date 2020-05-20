using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.Data.StatusE;

namespace WebDemo.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public bool IsShowOnHome { get; set; }
        public Status Status { get; set; }
        //Relationship
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
