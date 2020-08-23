using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational_DesignPattern.AbstractFactoryDesignPattern
{
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    class RegularBike : Bike
    {
        public string Name()
        {
            return "Regular Bike- Name";
        }
    }
}
