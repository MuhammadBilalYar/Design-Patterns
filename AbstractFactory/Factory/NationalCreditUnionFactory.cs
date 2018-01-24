using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
    {
    public class NationalLoanAccount :ILoanAccount
        {
        public NationalLoanAccount ()
            {
            Console.WriteLine ("National Loan Account Initiated.");
            }
        }
    public class NationalSavingsAccount :ISavingsAccount
        {
        public NationalSavingsAccount ()
            {
            Console.WriteLine ("National Saving Account Initiated.");
            }
        }
    public class NationalCreditUnionFactory :ICreditUnionFactory
        {
        public override ILoanAccount CreateLoanAccount ()
            {
            return new NationalLoanAccount ();
            }

        public override Interfaces.ISavingsAccount CreateSavingsAccount ()
            {
            return new NationalSavingsAccount ();
            }
        }
    }
