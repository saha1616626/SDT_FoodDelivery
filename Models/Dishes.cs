using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dishes
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int categoryId { get; set; }
        public int? calories { get; set; }
        public int? squirrels { get; set; }
        public int? fats { get; set; }
        public int? carbohydrates { get; set; }
        public int? weight { get; set; }
        public int? volume { get; set; }
        public int? quantity { get; set; }
        public int price { get; set; }
        public byte[] image { get; set; }
        public bool stopList { get; set; }

        // устанавливаем внешний ключ на таблицу Category
        public virtual Category Category { get; set; } = null!;

        // связываем CompositionOrder и Dishes
        public virtual ICollection<CompositionOrder> CompositionOrders { get; set; } = new List<CompositionOrder>();

        // связывем CompositionCart и Dishes
        public virtual ICollection<CompositionCart> CompositionCarts { get; set; } = new List<CompositionCart>();

        public Dishes() { }
    }
}
