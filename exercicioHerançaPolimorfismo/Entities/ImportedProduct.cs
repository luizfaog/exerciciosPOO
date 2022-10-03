using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHerançaPolimorfismo.Entities
{
    class ImportedProduct : product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $" (Custom Fee: {CustomFee})";
        }
    }
}
