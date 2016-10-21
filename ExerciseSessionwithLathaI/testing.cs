using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI
{
    class testing
    {
        public static void Main (string[] args)
        {
            //string s = "";
            //string t = null;
            //if (s == t)
            //{
            //    Console.Write("true");
            //}
            //else
            //{
            //    Console.Write("{0}", s.Length);
            //}

            string s2 = returnresult();

            Console.WriteLine(s2);

            int a = 0;
            int b = 0;

            returnresult2(ref a, ref b);

            Console.WriteLine("{0} and {1}", a, b);
           
           
        }

        public static string returnresult()
        {
            return "hello";
        }

        public static void returnresult2(ref int x, ref int y)
        {
            x = 1;
            y = 2;
        }
        
    }
}
