using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }
}
