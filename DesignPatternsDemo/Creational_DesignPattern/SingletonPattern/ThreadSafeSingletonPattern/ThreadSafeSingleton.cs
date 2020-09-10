using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Creational_DesignPattern.SingletonPattern.ThreadSafeSingletonPattern
{
   ///<summary>
   ///The 'Singleton' class
   ///</summary>
    public class ThreadSafeSingleton
    {
        ////.NET guarantees thread safety for static initialization
        private static ThreadSafeSingleton instance = null;
        private string Name { get; set; }
        private string IP { get; set; }
        private ThreadSafeSingleton()
        {
            //To DO: Remove below line
            Console.WriteLine("Singleton Intance");

            Name = "Server1";
            IP = "192.168.1.23";
        }
        ////Lock synchronization object
        private static object syncLock = new object();

        public static ThreadSafeSingleton GetInstance()
        {
                ////Support multithreaded applications through
                ////'Double checked locking' pattern which (once
                ////the instance exists) avoids locking each
                ////time the method is invoked
                lock (syncLock)
                {
                    if (ThreadSafeSingleton.instance == null)
                        ThreadSafeSingleton.instance = new ThreadSafeSingleton();

                    return ThreadSafeSingleton.instance;
                }
        }

        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
        }

    }
}
