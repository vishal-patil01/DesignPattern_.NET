using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational_DesignPattern.SingletonPattern.ThreadSafeSingletonPattern
{
   ///<summary>
   ///Singleton Pattern Demo
   ///</summary>
   ///
    public class ThreadSafeSingltonDemo
    {
        public static void Start()
        {
            ThreadSafeSingleton threadSafeSingletonOne = ThreadSafeSingleton.GetInstance();
            ThreadSafeSingleton threadSafeSingletonTwo = ThreadSafeSingleton.GetInstance();

            threadSafeSingletonOne.Show();
            threadSafeSingletonTwo.Show();
            Console.ReadKey();
        }
    }
}
