using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Role
    {
        public int id { get; set; }

        public string name { get; set; }

        // связываем Account и Role (установка внешнего ключа)
        public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

        public Role() { }

    }
}
