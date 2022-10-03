using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHerançaPolimorfismo.Entities
{
    class product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual string PriceTag()
        {
            return $"{Name} - ${Price}";
        }
        public product()
        {

        }

        public product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
