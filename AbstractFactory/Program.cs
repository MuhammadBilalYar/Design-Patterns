using AbstractFactory.Factory;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
    {
    class Program
        {
        static void Main (string[] args)
            {
            List<string> accountNos = new List<string> { "City-102", "National-456", "Invalid" };
            foreach (var account in accountNos)
                {
                ICreditUnionFactory factory = CreditUnionFactory.GetCreditUnionFactory (account);
                if (null != factory)
                    {
                    ILoanAccount loan = factory.CreateLoanAccount ();
                    ISavingsAccount saving = factory.CreateSavingsAccount ();
                    }
                else
                    {
                    Console.WriteLine ($"Invalid Account ({account}).");
                    }
                }
            }
        }
    }
