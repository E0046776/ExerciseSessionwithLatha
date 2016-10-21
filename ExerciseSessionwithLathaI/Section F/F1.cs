using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.Section_F
{
    class F1
    {

        public static void Main()
        {
            double[] sales = new double[12];
            double max, min;
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Enter the sales");
                string s = Console.ReadLine();
                sales[i] = Convert.ToDouble(s);
            }
            max = sales[0]; min = sales[0]; int maximum = 0; int minimum = 0;
            double sum = 0; double average = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (max < sales[i])
                    max = sales[i];
                maximum = i;
            }
            Console.WriteLine("The month when maximum sales is recorded is {0}", maximum);
                );
            for (int i = 1; i <= 12; i++)
            {
                if (min > sales[i])
                    min = sales[i];
                minimum = i;
            }
            Console.WriteLine("minimum sales is recorded in the {0} month", minimum);
            for (int i = 0; i < 12; i++)
            {
                sum = sum + sales[i];
            }
            average = sum / 12;
            Console.WriteLine("Average monthly sales is {0}", average);


        }
    }
}
