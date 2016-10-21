using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.Section_E
{
    class E3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());


            bool status = IsPrime(n);


            Console.WriteLine(status);
        }
        public static bool IsPrime(int n)
        {
            bool IsPrimeStatus = true;
            double half = n / 2.0;

            for (int k = 2; k < Math.Ceiling(half); k++)
            {
                double remainder = n % k;
                if (remainder != 0)
                {
                    IsPrimeStatus = true;
                }
                else
                {
                    IsPrimeStatus = false;
                    k = n;
                }

            }


            return IsPrimeStatus;
        }
    }

    
}
