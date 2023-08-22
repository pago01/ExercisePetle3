using System;
using System.ComponentModel.Design;

namespace ExercisePetle2
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Calculation

            int a = 0;
            int b = 1;

            do
            {
                Console.WriteLine(a);
                b = a + b;
                a = b - a;
            }
            while (b>0);
        }
    }
}
