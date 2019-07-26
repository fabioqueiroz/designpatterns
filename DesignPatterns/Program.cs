using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Test();

            foreach (var item in t.Emails)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    public class Test
    {
        public string[] Emails { get; } = { "one", "two" };
    }
}
