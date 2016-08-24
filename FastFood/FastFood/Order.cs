using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    public class Order
    {
        public int Id { get; set; }

        public IEnumerable<Food> Food { get; set; }

        private decimal _price;

        public decimal Price
        {
            get
            {
                if (Food.Count() > 0)
                {
                    return Food.Sum(f => Price);
                }
                return 0m;
            }
      
        }

        public Order()
        {
            Food = new List<Food>();
        }
    }
}
