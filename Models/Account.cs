using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Account
    {
        public int id { get; set; }
        public int roleId { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? patronymic { get; set; }
        public DateTime? registrationDate { get; set; }
        public string? email { get; set; }
        public string? numberPhone { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string? city { get; set; }
        public string? street { get; set; }
        public string? house { get; set; }
        public string? apartment { get; set; }

        // устанваливаем внешний ключ на таблицу Role
        public virtual Role Role { get; set; } = null!;

        // связываем ShoppingCart и Account (установка внешнего ключа)
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

        // связываем Order и Account (установка внешнего ключа)
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

        public Account() { }
    }
}
