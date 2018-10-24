using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Show();
            Singleton.Instance.Show();

            Console.ReadKey();
        }
    }
}
