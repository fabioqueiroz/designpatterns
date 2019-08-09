using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new WineFactory(WineType.Bordeaux);
            var factory2 = new WineFactory(WineType.Rioja);
            var factory3 = new WineFactory(WineType.Porto);

            Console.WriteLine(factory.CheckWineTaste());
            Console.WriteLine(factory2.CheckWineTaste());
            Console.WriteLine(factory3.CheckWineTaste());

            
            Console.ReadKey();
        }
    }
}
