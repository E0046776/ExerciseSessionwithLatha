using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.Section_E
{
    class E1
    {
     public static void Main()
        {
            int factorial=1 ; int var=1;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=2;i<=num;i++)
            {
                factorial = factorial * i;
            }
            for (int i= num; i>1;i--)
            {
                var = var * i;
            }
            Console.WriteLine("The factorial of {0} is {1}", num, factorial);
            Console.WriteLine("The factorial of {0} is {1}", num, var);
        }
    }
}
