using System;
using AbstractClass.classes;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank gtb = new BankA();
            gtb.Balance(100);

            Bank access = new BankB();
            access.Balance(150);

            Bank fidelity = new BankC();
            fidelity.Balance(200);
        }
    }
}
