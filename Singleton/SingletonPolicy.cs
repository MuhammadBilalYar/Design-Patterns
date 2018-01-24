using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
    {
    public class SingletonPolicy
        {
        private static readonly SingletonPolicy _instance = new SingletonPolicy ();
        public static SingletonPolicy Instance
            {
            get
                {
                return _instance;
                }
            }
        private SingletonPolicy ()
            {

            }
        private int Id { get; set; } = 789;
        private string Insured { get; set; } = "Muhammad Bilal";

        public string GetInsuredName ()
            {
            return Insured;
            }
        }
    }
