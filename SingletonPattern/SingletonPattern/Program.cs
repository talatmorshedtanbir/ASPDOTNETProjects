using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton ins1 = Singleton.GetInstance();
            ins1.WriteLog("Hello from instance one");

            Singleton ins2 = Singleton.GetInstance();
            ins2.WriteLog("Hello from instance two");
        }
    }

    public class Singleton
    {
        private static readonly object padlock = new object();
        private static Singleton instance;
        private Singleton() { }
        public static Singleton GetInstance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
            return instance;
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($" {message} {instance} ");
        }

    }

}