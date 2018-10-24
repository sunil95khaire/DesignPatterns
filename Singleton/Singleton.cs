using System;

namespace Singleton
{
    public sealed class Singleton
    {
        // Lazy initialization
        // .NET guarantees thread safety for static initialization
        private static Singleton instance = null;
        private string Name { get; set; }
        private string IP { get; set; }

        private Singleton()
        {
            Name = "Server1";
            IP = "192.168.1.23";
        }

        // Lock synchronization object
        private static readonly object syncLock = new object();

        public static Singleton Instance
        {
            get
            {
                // Support multithreaded applications through
                // 'Double checked locking' pattern which (once
                // the instance exists) avoids locking each
                // time the method is invoked
                lock (syncLock)
                {
                    if (instance == null)
                        instance = new Singleton();

                    return instance;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
        }
    }
}

/*
//eager initialization of singleton
public class Singleton
{
    private static Singleton instance = new Singleton();
    private Singleton() { }

    public static Singleton GetInstance
    {
        get
        {
            return instance;
        }
    }
}

////lazy initialization of singleton
public class Singleton
{
    private static Singleton instance = null;
    private Singleton() { }

    public static Singleton GetInstance
    {
        get
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }
    }
}

////Thread-safe (Double-checked Locking) initialization of singleton
public class Singleton
{
    private static Singleton instance = null;
    private Singleton() { }
    private static object lockThis = new object();

    public static Singleton GetInstance
    {
        get
        {
            lock (lockThis)
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }
    }
}
*/