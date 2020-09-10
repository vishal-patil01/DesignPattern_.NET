﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural_DesignPattern.AdapterDesignPattern
{
   ///<summary>
   ///The 'Client' class
   ///</summary>
    public class ThirdPartyBillingSystem
    {
        private ITarget employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            List<string> employee = employeeSource.GetEmployeeList();
            //To DO: Implement you business logic

            Console.WriteLine("######### Employee List ##########");
            foreach (var item in employee)
            {
                Console.Write(item);
            }

        }
    }
}
