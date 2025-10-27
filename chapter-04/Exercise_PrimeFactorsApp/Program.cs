using System;
using Exercise_PrimeFactorsLib;

Console.Write("Enter integer: ");
if (int.TryParse(Console.ReadLine(), out var n))
{
    Console.WriteLine(PrimeFactors.PrimeFactors(n));
}
else
{
    Console.WriteLine("Invalid input");
}
