using System.Collections;
using System.Security.Cryptography;

namespace UnieTestForTax;

public static class TaxProvider 
{
   static public List<Tax> GivenTaxList()
    {
        return new List<Tax>
        {
            new Tax(0m, 540000m, 0.05m, 27_000m),
            new Tax(540001m, 1210000m, 0.12m, 80_400m),
            new Tax(1210001m, 2420000m, 0.20m, 242_000m),
            new Tax(2420001m, 4530000m, 0.30m, 633_000m),
            new Tax(4530001m, 10310000m, 0.40m, 2_312_000m),
            new Tax(10310001m, decimal.MaxValue, 0.50m)
        };
    }
    
}