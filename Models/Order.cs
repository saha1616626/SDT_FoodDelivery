using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public int id { get; set; }
        public DateTime? dateTime { get; set; }
        public DateTime? startDesiredDeliveryTime { get; set; }
        public DateTime? endDesiredDeliveryTime { get; set; }
        public int? accountId { get; set; }
        public int? orderStatusId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string? patronymic { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string house { get; set; }
        public string? apartment { get; set; }
        public string? numberPhone { get; set; }
        public string? email { get; set; }
        public int costPrice { get; set; }
        public string typePayment { get; set; }
        public int? prepareChangeMoney { get; set; }

        // устанваливаем внешний ключ на таблицу Account
        public virtual Account Account { get; set; } = null!;

        // устанваливаем внешний ключ на таблицу OrderStatus
        public virtual OrderStatus OrderStatus { get; set; } = null!;

        // связываем CompositionOrder и Order
        public virtual ICollection<CompositionOrder> CompositionOrders { get; set; } = new List<CompositionOrder>();

        public Order() { }
    }
}
