
namespace DesignPatternsDemo
{
    using DesignPatternsDemo.Structural_DesignPattern.AdapterDesignPattern;
    using DesignPatternsDemo.Structural_DesignPattern.BridgePattern;
    using System;

    class StructuralPatternDemo
    {
        public static void Start()
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1 To See Adapter Design Pattern");
                Console.WriteLine("2 To See Bridge Design Pattern");
                Console.WriteLine("0 To Go Back");
                choice = (char)Console.Read();
                Console.WriteLine("------------------------------------");
                switch (choice)
                {
                    case '1':
                        AdpterDesignPatternDemo.Start();
                        break;
                    case '2':
                        BridgePatternDemo.Start();
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
