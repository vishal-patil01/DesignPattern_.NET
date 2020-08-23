using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral_DesignPattern.ObserverPattern
{
    /// <summary>

    /// MainApp startup class for Real-World 

    /// Observer Design Pattern.

    /// </summary>

   public class ObserverPatternDemo
    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

       public static void Start()
        {
            // Create IBM stock and attach investors

            Console.Clear();
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            // Wait for user

            Console.ReadKey();
        }
    }



    
   

   
   
}
