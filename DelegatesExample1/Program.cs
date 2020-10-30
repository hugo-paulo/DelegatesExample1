using System;

namespace DelegatesExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopLength;

            Console.WriteLine("Enter Length of Loop");
            loopLength = Int32.Parse(Console.ReadLine());

            var loop = new LoopClass(() => { Console.WriteLine("Loop Complete !!!"); }, loopLength);
            loop.RunLoop();

        }

    }
}
