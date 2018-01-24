using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
    {
    class Program
        {
        static void Main (string[] args)
            {
            //Created two instance
            var obj1 = SingletonPolicy.Instance;
            var obj2 = SingletonPolicy.Instance;
            Console.WriteLine (obj1 == obj2);

            Console.WriteLine (obj1.GetInsuredName());
            Console.WriteLine (obj2.GetInsuredName ());
            }
        }
    }
