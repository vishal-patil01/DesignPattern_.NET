
namespace DesignPatternsDemo
{
    using DesignPatternsDemo.Creational_DesignPattern.AbstractFactoryDesignPattern;
    using DesignPatternsDemo.Creational_DesignPattern.FactoryDesignPattern;
    using System;

    class CreationalPatternDemo
    {
        public static void Start()
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("------Creational Pattern Demo-------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1 To See Singleton Design Pattern");
                Console.WriteLine("2 To See Factory Design Pattern");
                Console.WriteLine("3 To See AbstractFactory Design Pattern");
                Console.WriteLine("0 To Go Back");
                Console.WriteLine("------------------------------------");
                choice = (char)Console.Read();;
                switch (choice)
                {
                    case '1':
                        SingletonPattern.Start();
                        break;
                    case '2':
                        FactoryPatternDemo.Start();
                        break;
                    case '3':
                        AbstractFactoryDemo.Start();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }

            } while (choice !='0');
        }
    }
}
