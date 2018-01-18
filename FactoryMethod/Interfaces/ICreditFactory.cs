﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Interfaces
    {
    interface ICreditFactory
        {
        ISavingsAccount GetSavingsAccount (string accountNo);
        }
    }
