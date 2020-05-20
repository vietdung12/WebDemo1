using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Data.Entities
{
    public class CategoryTranslation
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LanguageId { get; set; }
        //Relationship
        public Category Category { get; set; }
        public Language Language { get; set; }
    }
}
