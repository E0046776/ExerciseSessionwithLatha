using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSessionwithLathaI.SectionC
{
    class c6
    {
        public static void Main()
        {
           for(int i= 0; i<9;i++)
            {
                int I_TV=0;int I_DVD=0;int I_MP3=0;int netprice = 0;
                for (int j = 0; j < 3; j++)
                {

                    Console.WriteLine("Enter the ProductCode: TV or DVD or MP3");
                    string S = Console.ReadLine();
                    Console.WriteLine("Enter the Quantity");
                    if (S == "TV")
                    {  I_TV = Convert.ToInt32(Console.ReadLine()); }//if TV is entered
                    else if (S == "DVD")
                    {  I_DVD = Convert.ToInt32(Console.ReadLine()); } //if DVD is entered
                    else if (S == "MP3")
                    {  I_MP3 = Convert.ToInt32(Console.ReadLine()); }//if mp3 is entered
                }
                int totalprice = (I_TV * 900) + (I_DVD * 500) + (I_MP3 * 700);
                if(totalprice>5000 && totalprice<10000)

                {
                    int discount = ( (I_TV * 900) + (I_DVD * 500) ) * 10 / 100;
                     netprice = totalprice - discount;
                }
                else if (totalprice>10000)
                {
                    int discount = ((I_TV * 900) + (I_DVD * 500)) * 15 / 100;
                     netprice = totalprice - discount;
                }

                Console.WriteLine("TV\t\tDVD\t\tMP3\t\tDiscountPrice");
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}",I_TV,I_DVD,I_MP3,netprice);    
            }

       }
    }
}
