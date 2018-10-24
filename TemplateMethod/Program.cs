using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Document html = new HtmlDocument();
            html.Print();

            Document xml = new XMLDocument();
            xml.Print();

            Document d = new HtmlDocument();
            d.Display();

            HtmlDocument d1 = new HtmlDocument();
            d1.Display();

            Console.ReadKey();
        }
    }
}
