using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
