using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational_DesignPattern.FactoryDesignPattern
{
   ///<summary>
   ///The Creator Abstract Class
   ///</summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
    }
}
