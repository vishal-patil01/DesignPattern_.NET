using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural_DesignPattern.AdapterDesignPattern
{
   ///
   ///Adapter Design Pattern Demo
   ///
    public class AdpterDesignPatternDemo
    {
        public static void Start()
        {
            ITarget Itarget = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
            client.ShowEmployeeList();

            Console.ReadKey();

        }
    }
}
