using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.Section_E
{
    class E2
    {
      public static void Main()
        {
            Console.WriteLine("No\t\t\tInverse\t\t\tSquare root\t\t\tSquare");
            
            for (int i = 1; i <= 10; i++)
            {
               double inv = 1.0 / i;
               double sqrt = Math.Sqrt(i);
               double square = Math.Pow(i, 2);

                Console.WriteLine("{0}\t\t\t{1:0.000}\t\t\t{2:0.000}\t\t\t{3}", i, inv, sqrt, square);
            }

        }
   }
}
