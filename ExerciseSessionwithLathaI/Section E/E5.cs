using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.Section_E
{
    class E5
    {
        public static void Main()
        {
            for (int i =5;i<10000;i++)
            {
                double half = i / 2.0;int counter = 0;
                for (int j = 2; j <= Math.Ceiling(half); j++)
                {
                    if (i % j == 0)
                    {
                        counter = counter + 1;
                        break;
                    }
                 }
                if (counter==0)
                Console.WriteLine("{0} is a prime no", i);

             }

        }
    }
}
