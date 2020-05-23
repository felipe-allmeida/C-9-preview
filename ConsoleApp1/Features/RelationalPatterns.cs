using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Features
{    
    public class RelationalPatterns
    {
        public static void Run()
        {
            Console.WriteLine("GetGrade(10): " + GetGrade(10));
            Console.WriteLine("GetGrade(49): " + GetGrade(49));
            Console.WriteLine("GetGrade(72): " + GetGrade(72));
            Console.WriteLine("GetGrade(98): " + GetGrade(98));
        }

        public enum EGrade
        {
            F,
            E,
            D,
            C,
            B,
            A
        }

        public static EGrade GetGrade(int score) => score switch
        {
            < 25 => EGrade.F,
            < 50 => EGrade.D,
            < 70 => EGrade.C,
            < 85 => EGrade.B,
            _ => EGrade.A,
        };
    }
}