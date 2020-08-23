
namespace DesignPatternsDemo
{
    using System;

    class DesignPatternDemo
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("--------Design Pattern Demo---------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1 To See Creational Design Pattern");
                Console.WriteLine("2 To See Behavioral Design Pattern");
                Console.WriteLine("3 To See Structural Design Pattern");
                Console.WriteLine("0 To Exit");
                Console.WriteLine("------------------------------------");
                choice = (char)Console.Read();;
                switch (choice)
                {
                    case '1':
                        CreationalPatternDemo.Start();
                        break;
                    case '2':
                        BehavioralPatternDemo.Start();
                        break;
                    case '3':
                        StructuralPatternDemo.Start();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }

            } while (choice !='0');
        }
    }
}
