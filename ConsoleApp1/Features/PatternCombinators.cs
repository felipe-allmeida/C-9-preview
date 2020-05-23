using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Features
{
    public static class PatternCombinators
    {
        public static void Run()
        {
            Console.WriteLine("a is letter? " + IsLetter('a'));
            Console.WriteLine("8 is letter? " + IsLetter('8'));
            Console.WriteLine("Z is letter? " + IsLetter('Z'));
            Console.WriteLine("$ is letter? " + IsLetter('$'));

            var obj = new object();

            Console.WriteLine("obj IsNull? " + IsNull(obj));
            Console.WriteLine("obj IsNotNull? " + IsNotNull(obj));

            Console.WriteLine("50 is IsBetweenZeroAndHundred? " + IsBetweenZeroAndHundred(50));
            Console.WriteLine("50F is IsBetweenZeroAndHundred? " + IsBetweenZeroAndHundred(50F));
            Console.WriteLine("50D is IsBetweenZeroAndHundred? " + IsBetweenZeroAndHundred(50D));

            Console.WriteLine("150 IsIntGreaterThan100? " + IsBetweenZeroAndHundred(150));
            Console.WriteLine("50 IsIntGreaterThan100? " + IsBetweenZeroAndHundred(50));
            Console.WriteLine("150F IsIntGreaterThan100? " + IsBetweenZeroAndHundred(50F));
            Console.WriteLine("50D IsIntGreaterThan100? " + IsBetweenZeroAndHundred(50D));
        }
        public static bool IsLetter(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');

        public static bool IsBetweenZeroAndHundred(object n) => n is
            >= 0 and <= 100 or
            >= 0F and <= 100F or
            >= 0D and <= 100D;

        public static bool IsNull(object obj) => obj is null;

        public static bool IsNotNull(object obj) => obj is not null;
        

        public static bool IsIntGreaterThan100(object obj) => obj is int and >= 100; 

        public static void Switch(int n)
        {
            switch(n)
            {
                case < 0: break;
                case 0 or 1 or 2 or 3 or 4: break;
                case >= 5 and <= 10: break;
                default: throw new Exception();
            }
        }
    }
}
