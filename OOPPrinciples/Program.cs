using System;

namespace OOPPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Encapsulation.Rectangle rectangle = new Encapsulation.Rectangle();
            rectangle.SetHeigth(10);
            rectangle.SetWidth(20);

            Abstraction.SpanControl spanControl = new Abstraction.SpanControl();
            var output = spanControl.Output();

        }
    }
}
