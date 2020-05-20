using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Data.Entities
{
    public class ProductTranslation
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LanguageId { get; set; }
        //Relationship
        public Product Product { get; set; }
        public Language Language { get; set; }
    }
}
