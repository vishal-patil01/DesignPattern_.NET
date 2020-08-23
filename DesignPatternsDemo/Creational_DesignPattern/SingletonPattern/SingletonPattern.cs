
namespace DesignPatternsDemo
{
    using DesignPatternsDemo.Creational_DesignPattern.SingletonPattern.ThreadSafeSingletonPattern;
    using DesignPatternsDemo.Creational_DesignPattern.SingletonPattern.ThreadUnsafeSingletonPattern;
    using System;

    class SingletonPattern
    {
        public static void Start()
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("-------Singleton Pattern Demo-------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1 To See Thread Unsafe Singleton Design Pattern");
                Console.WriteLine("2 To See Thread safe Singleton Design Pattern");
                Console.WriteLine("0 To Go Back");
                Console.WriteLine("------------------------------------");
                choice = (char)Console.Read();;
                switch (choice)
                {
                    case '1':
                        ThreadUnsafeSingltonDemo.Start();
                        break;
                    case '2':
                        ThreadSafeSingltonDemo.Start();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }

            } while (choice !='0');
        }
    }
}
