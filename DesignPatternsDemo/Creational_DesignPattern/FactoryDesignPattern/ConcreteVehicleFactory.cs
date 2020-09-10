﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational_DesignPattern.FactoryDesignPattern
{
   ///<summary>
   ///A 'ConcreteCreator' class
   ///</summary>
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }

    }

}
