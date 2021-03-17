using System;

namespace ReversedCases
{
    class Program
    {
        // https://edabit.com/challenge/99oN5igrbXddAjHEL
        // SOLVED

        static void Main(string[] args)
        {
            var case1 = new CaseReverser("Happy Birthday");
            Console.Write(case1.InvertCapitalization());
        }
    }
}
