using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        public int id { get; set; }

        public string? name { get; set; }

        public string? description { get; set; }

        // связываем Dishes и Category (установка внешнего ключа)
        public virtual ICollection<Dishes> Dishes { get; set; } = new List<Dishes>();

        public Category() { }

    }
}
