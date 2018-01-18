using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
    {
    public class CitySavingsAccount :ISavingsAccount
        {
        public CitySavingsAccount ()
            {
            Balance = 5000;
            }
        }
    }
