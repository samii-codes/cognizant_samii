using System;

class Program
{
    
    public static double FutureValue(double principal, double rate, int years)
    {
        if (years == 0)
            return principal;
        return (1 + rate) * FutureValue(principal, rate, years - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual rate in decimal 0.1 for 10%: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number of years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        double futureValue = FutureValue(principal, rate, years);
        Console.WriteLine($"Future Value after {years} years: {futureValue:F2}");
    }
}
