using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.Section_E
{
    class E4
    {
        public static void Main()
        {
            // to check if the given no is a perfect no or not
            Console.WriteLine("Please enter the no");
            int num = Convert.ToInt32(Console.ReadLine());
            double half = num / 2.0;
            int sum = 1;
            for (int i = 2; i <= Math.Ceiling(half); i++)
            {
                
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
                Console.WriteLine("{0} is a perfect no", num);
            else
                Console.WriteLine("{0} is not a perfect number", num);
        }

    }
}
