using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational_DesignPattern.SingletonPattern.ThreadUnsafeSingletonPattern
{
   ///<summary>
   ///Singleton Pattern Demo
   ///</summary>
   ///
    public class ThreadUnsafeSingltonDemo
    {
        public static void Start()
        {
            ThreadUnsafeSingleton threadSafeSingletonOne = ThreadUnsafeSingleton.GetInstance();
            ThreadUnsafeSingleton threadSafeSingletonTwo = ThreadUnsafeSingleton.GetInstance();

            threadSafeSingletonOne.Show();
            threadSafeSingletonTwo.Show();
            Console.ReadKey();
        }
    }
}
