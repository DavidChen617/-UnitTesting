namespace UnieTestForTax;

class Program
{
    static void Main(string[] args)
    {
        decimal input;
        Console.WriteLine("請輸入年薪");
        if (!decimal.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("請輸入正確數字!");  
        }
        else
        {
            CalculateTax cal = new();
            Console.WriteLine("你該繳得稅為: ");
            Console.WriteLine(cal.Calculate(input).ToString("###,###.##") + "元");
        }
    }
}