using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
    {
    public abstract class ICreditUnionFactory
        {
        public abstract ISavingsAccount CreateSavingsAccount ();
        public abstract ILoanAccount CreateLoanAccount ();
        }
    }
