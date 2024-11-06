using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CompositionOrder
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int? dishesId { get; set; }
        public int? quantityOrder { get; set; }
        public int amountPrice { get; set; }

        // устанавливаем внешний ключ на таблицу Order
        public virtual Order Order { get; set; } = null!;

        // устанавливаем внешний ключ на таблицу Dishes
        public virtual Dishes Dishes { get; set; }
    }
}
