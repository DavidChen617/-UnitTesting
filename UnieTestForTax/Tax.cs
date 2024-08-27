namespace UnieTestForTax;

public class Tax
{
    private decimal _min;
    private decimal _max;
    private decimal _taxRate;
    private decimal _taxResult;
    public decimal Min
    {
        get => _min;
      
    }

    public decimal Max
    {
        get => _max;
      
    }

    public decimal TaxRate
    {
        get => _taxRate;
       
    }

    public decimal taxResult {get => _taxResult;}

    public Tax(decimal min, decimal max, decimal taxRate,decimal taxResult=0) =>
        (_min,_max,_taxRate,_taxResult) = (min, max, taxRate,taxResult);
    
}