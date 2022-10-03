using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHerançaPolimorfismo.Entities
{
    class UsedProduct : product
    {
        public DateTime ManufatureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufatureDate) : base(name, price)
        {
            ManufatureDate = manufatureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $" (Manufature Date: {ManufatureDate})";
        }
       

    }
}
