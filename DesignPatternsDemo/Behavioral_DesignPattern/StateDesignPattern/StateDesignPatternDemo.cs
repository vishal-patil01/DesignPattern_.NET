using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Behavioral_DesignPattern.StateDesignPattern
{
   ///<summary>

   ///MainApp startup class for Real-World 

   ///State Design Pattern.

   ///</summary>

    public class StateDesignPatternDemo

    {
       ///<summary>

       ///Entry point into console application.

       ///</summary>

        public static void Start()
        {
            ////Open a new account

            Account account = new Account("Jim Johnson");

            ////Apply financial transactions
            Console.Clear();
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            ////Wait for user

            Console.ReadKey();
        }
    }
}


