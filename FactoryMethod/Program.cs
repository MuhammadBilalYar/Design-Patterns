using FactoryMethod.Factories;
using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod
    {
    class Program
        {
        static void Main (string[] args)
            {
            ICreditFactory factory = new SavingsAccountFactory ();
            var cityAccount = factory.GetSavingsAccount ("City 102");
            var nationalAccount = factory.GetSavingsAccount ("National 103");

            Console.WriteLine ($"City Balance: {cityAccount.Balance}");
            Console.WriteLine ($"National Balance: {nationalAccount.Balance}");
            }
        }
    }
