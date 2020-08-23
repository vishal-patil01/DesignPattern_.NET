﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral_DesignPattern.ObserverPattern
{
    /// <summary>

    /// The 'ConcreteSubject' class

    /// </summary>

    class IBM : Stock

    {
        // Constructor

        public IBM(string symbol, double price)
          : base(symbol, price)
        {
        }
    }
}
