namespace UnieTestForTax;

public class CalculateTax : ICalculate<decimal>
{
    public decimal Calculate(decimal income)
    {
        var res = TaxProvider.GivenTaxList().Where(x => income >= x.Min)
            .Select(x => income >= x.Max ? x.taxResult : ((income )+1- x.Min) * x.TaxRate).Sum();
        return res;
    }
}