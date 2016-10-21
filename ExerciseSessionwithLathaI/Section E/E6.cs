using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.Section_E
{
    class E6
    {
        public static void Main()
        {
            for(int i=1; i<=1000; i++)
            {
                int sum = 0;
                double half = i / 2.0;
                for(int j=1; j<=Math.Ceiling(half); j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                 }
                if (sum == i)
                    Console.WriteLine("{0} is a perfect number", i);
            }

        }

    }
}
