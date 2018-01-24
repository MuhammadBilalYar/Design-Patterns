using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
    {
    public class CityLoanAccount :ILoanAccount
        {
        public CityLoanAccount ()
            {
            Console.WriteLine ("City Loan Account Initiated.");
            }
        }

    public class CitySavingsAccount:ISavingsAccount
        {
        public CitySavingsAccount()
            {
            Console.WriteLine ("City Savings Account Initiated.");
            }
        }
    public class CityCreditUnionFactory :ICreditUnionFactory
        {
        public override ILoanAccount CreateLoanAccount ()
            {
            return new CityLoanAccount ();
            }

        public override ISavingsAccount CreateSavingsAccount ()
            {
            return new CitySavingsAccount ();
            }
        }
    }
