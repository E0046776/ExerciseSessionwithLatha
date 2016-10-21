using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.Section_D
{
    class D4
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            double G = r.Next(1, n);
            do
            {
                G = (G + n / G) / 2;
            }
            while (Math.Abs(G * G - n) >= 0.00001);
            Console.WriteLine("sQRT of {1} is {0:###.###}", G,n);

        }

    }
}

