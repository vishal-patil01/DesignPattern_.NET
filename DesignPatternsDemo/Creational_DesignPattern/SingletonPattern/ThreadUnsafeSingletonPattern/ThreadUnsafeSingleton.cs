using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational_DesignPattern.SingletonPattern.ThreadUnsafeSingletonPattern
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class ThreadUnsafeSingleton
    {
        // .NET guarantees thread safety for static initialization
        private static ThreadUnsafeSingleton instance = null;
        private string Name { get; set; }
        private string IP { get; set; }
        private ThreadUnsafeSingleton()
        {
            //To DO: Remove below line
            Console.WriteLine("Singleton Intance");

            Name = "Server1";
            IP = "192.168.1.23";
        }

        public static ThreadUnsafeSingleton GetInstance()
        {
            if (ThreadUnsafeSingleton.instance == null)
                ThreadUnsafeSingleton.instance = new ThreadUnsafeSingleton();

            return ThreadUnsafeSingleton.instance;

        }

        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
        }

    }
}
