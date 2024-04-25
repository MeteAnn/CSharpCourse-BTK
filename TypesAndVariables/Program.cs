using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Value Types
            //Console.WriteLine( "Hello World");


            decimal number6 = 10.4m;
            double number5 = 10.4;
            char charecter = 'A';
            string city = "Ankara";
            bool condition = true; //true veya false
            byte number4 = 255;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 2147483648;
            var number7 = 10;
            number7 = 'A';

            Console.WriteLine("Number 1 is {0}",number1);
            Console.WriteLine("Number 2 is {0}", number2);
            Console.WriteLine("Number 3 is {0}", number3);
            Console.WriteLine("Number 4 is {0}", number4);
            Console.WriteLine("Number 4 is {0}", number5);
            Console.WriteLine("Number 7 is {0}", number7);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Charecter 1 is {0}", charecter);
            Console.ReadLine();


        }
    }



    enum Days
    {
        Monday, Tuesday, Wednesday,Thursday,Friday,Saturday, Sunday
    }


}


