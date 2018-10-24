using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter command (On/OFF)");
            string cmd = Console.ReadLine();

            Light li = new Light();
            ICommand up = new FlipUpCommand(li);
            ICommand down = new FlipDownCommand(li);

            Switch s = new Switch();

            if (cmd == "ON")
            {
                s.StoreAndExecute(up);
            }
            else if (cmd == "OFF")
            {
                s.StoreAndExecute(down);
            }
            else
            {
                Console.WriteLine("ON OFF required");
            }

            Console.ReadKey();
        }
    }
}
