
using System;
using static DetectHome.CollectionsPractice;

double CompoundInterest(double principal, double rate, int years)
{
    double compoundFactor = Math.Pow(1 + rate / 100, years);
    return principal * compoundFactor;
}

double SimpleInterest(double principal, double rate, int years)
{
    return principal * (1 + (rate / 100) * years);
}

double InitialPayment(double principal)
{
    return principal / 10; // You can adjust this based on your requirements
}

BankAccount ipoteka = new BankAccount(100_000_000, CompoundInterest);
BankAccount mashina = new BankAccount(50_000_000, CompoundInterest);
BankAccount maqsadsiz = new BankAccount(10_000_000, CompoundInterest);
BankAccount imtiyozli = new BankAccount(1_000_000_000, SimpleInterest);
BankAccount talim = new BankAccount(8_000_000, SimpleInterest);

Console.WriteLine($"Ipoteka uchun boshlang'ich to'lov: {ipoteka.CalculateFinalAmount(20):C}");
Console.WriteLine($"Mashina uchun boshlang'ich to'lov: {mashina.CalculateFinalAmount(5):C}");
Console.WriteLine($"Maqsadsiz kredit uchun boshlang'ich to'lov: {maqsadsiz.CalculateFinalAmount(3):C}");
Console.WriteLine($"Imtiyozli kredit uchun boshlang'ich to'lov: {imtiyozli.CalculateFinalAmount(20):C}");
Console.WriteLine($"Ta'lim kredit uchun boshlang'ich to'lov: {talim.CalculateFinalAmount(5):C}");

/*namespace CollectionsPractice.Console
{
    
}*/
