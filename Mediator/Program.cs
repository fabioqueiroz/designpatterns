using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator m = new Mediator();

            m.ChangeState("test");

            Console.ReadKey();
        }
    }
}
