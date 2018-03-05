using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Country : BaseModel<int>
    {
        public Country()
        {
            this.Customers = new HashSet<Customer>();
        }

        public string Name { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
