using System;

namespace TemplateMethod
{
    public class HtmlDocument : Document
    {
        public override void PrintBody()
        {
            Console.WriteLine("Html Body");
        }

        public override void PrintFooter()
        {
            Console.WriteLine("Html Footer");
        }

        public override void PrintHeader()
        {
            Console.WriteLine("Html Header");
        }

        public new void Display()
        {
            Console.WriteLine("Derived class");
        }
    }
}
