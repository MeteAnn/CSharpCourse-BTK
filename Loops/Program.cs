using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //for (int i = 0; i < 100; i++)
            //{


            //    Console.WriteLine(i);


            //}
            //Console.WriteLine("Finished");




            //int number = 100;

            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //Console.WriteLine("Now Number is {0}",number);

            //int number = 100;

            //do
            //{

            //    Console.WriteLine(number);
            //    number--;
            //}
            //while (number>=0);


            if (IsPrimeNumber(6))
            {

                Console.WriteLine("This is a prime number");
            }
            else
            {

                Console.WriteLine("This is a not prime number");


            }


            Console.ReadLine(); 



        }


        private static bool IsPrimeNumber(int number)
        {

            bool result = true;
            for (int i = 2; i < number-1; i++)
            {

                if (number%i==0)
                {

                    result = false;
                    i = number;

                }

            }

            return result;

        }





    }
}
