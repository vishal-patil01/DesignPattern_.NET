using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational_DesignPattern.AbstractFactoryDesignPattern
{
    /// <summary>
    /// The 'AbstractFactory' interface. 
    /// </summary>
    interface VehicleFactory
    {
        Bike GetBike(string Bike);
        Scooter GetScooter(string Scooter);
    }
}
