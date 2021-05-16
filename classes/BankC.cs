using System;

namespace AbstractClass.classes
{
    public class BankC : Bank
    {
        
        public override void Balance(decimal deposit)
        {
             Console.WriteLine($"Your Balance is ${deposit}");
        }
    }
}