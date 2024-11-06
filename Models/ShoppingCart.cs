﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ShoppingCart
    {
        public int id { get; set; }

        public int? accountId { get; set; }

        public int? costPrice { get; set; }

        // устанавливаем внешний ключ на таблицу Account
        public virtual Account Account { get; set; } = null!;

        // связываем CompositionCart и ShoppingCart (установка внешнего ключа)
        public virtual ICollection<CompositionCart> CompositionCarts { get; set; } = new List<CompositionCart>();

        public ShoppingCart() { }

    }
}
