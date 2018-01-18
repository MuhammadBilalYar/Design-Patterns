using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
    {
    public class SavingsAccountFactory:ICreditFactory
        {
        public ISavingsAccount GetSavingsAccount (string accountNo)
            {
            if (accountNo.Contains (Constants.CITY_ACCOUNT))
                {
                return new CitySavingsAccount ();
                }
            else if (accountNo.Contains (Constants.NATIONAL_ACCOUNT))
                {
                return new NationalSavingsAccount ();
                }
            else
                throw new ArgumentException ("Invalid Account Number");
            }
        }
    }
