using System;

namespace TemplateMethod
{
    public class XMLDocument : Document
    {
        public override void PrintBody()
        {
            Console.WriteLine("XML Body");
        }

        public override void PrintFooter()
        {
            Console.WriteLine("XML Footer");
        }

        public override void PrintHeader()
        {
            Console.WriteLine("XML Header");
        }
    }
}
