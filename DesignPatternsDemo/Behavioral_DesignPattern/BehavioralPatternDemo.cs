
namespace DesignPatternsDemo
{
    using DesignPatternsDemo.Behavioral_DesignPattern.ObserverPattern;
    using DesignPatternsDemo.Behavioral_DesignPattern.StateDesignPattern;
    using System;

    class BehavioralPatternDemo
    {
        public static void Start()
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("------Behavioral Pattern Demo-------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1 To See State Design Pattern");
                Console.WriteLine("2 To See Observer Design Pattern");
                Console.WriteLine("0 To Go Back");
                choice = (char)Console.Read();;
                Console.WriteLine("------------------------------------");
                switch (choice)
                {
                    case '1': StateDesignPatternDemo.Start();
                        break;
                    case '2': ObserverPatternDemo.Start();
                        break;
                    case '3': break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }

            } while (choice !='0');
        }
    }
}
