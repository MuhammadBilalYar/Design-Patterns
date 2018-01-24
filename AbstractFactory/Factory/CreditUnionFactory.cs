using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
    {
    public class CreditUnionFactory
        {
        public static ICreditUnionFactory GetCreditUnionFactory (string accountNo)
            {
            if (accountNo.Contains (Constants.CITY_ACCOUNT))
                {
                return new CityCreditUnionFactory ();
                }
            else if (accountNo.Contains (Constants.NATIONAL_ACCOUNT))
                {
                return new NationalCreditUnionFactory ();
                }
            else
                return null;
            }
        }
    }
