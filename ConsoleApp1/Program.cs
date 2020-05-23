using ConsoleApp1.Features;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RelationalPatterns");
            RelationalPatterns.Run();

            Console.WriteLine("PatternMatching");
            PatternMatching.Run();
            
            Console.WriteLine("PatternCombinators");
            PatternCombinators.Run();
            Console.ReadLine();
        }
    }    
}
