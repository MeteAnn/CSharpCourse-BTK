﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {



        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int nuöber1, int number2);


        static void Main(string[] args)
        {

            //CustomerManager customerManager = new CustomerManager();
            ////customerManager.SendMessage();
            ////customerManager.ShowAlert();


            //MyDelegate myDelegate = customerManager.SendMessage;


            //myDelegate += customerManager.ShowAlert;



            //myDelegate -= customerManager.SendMessage;


            //MyDelegate2 myDelegate2 = customerManager.SendMessage2;

            //myDelegate2 += customerManager.ShowAlert2;




            //Matematik matematik = new Matematik();


            //MyDelegate3 myDelegate3 = matematik.Topla;



            //myDelegate3 += matematik.Carp;

            //var sonuc = myDelegate3(1, 2);

            //myDelegate2("Hello");

            //myDelegate();

            Func<int, int, int> add = Topla;



            Func<int> getRandomNumber = delegate ()
            {


                Random random = new Random();

                return random.Next(1,100);


            };

           

            Func<int> getRandomNumber2 = () => new Random().Next(1,100);

            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber2());

            //Console.WriteLine(Topla(2,3));


            Console.ReadLine();


        }


        static int Topla(int x, int y)
        {


            return x + y;


        }



        public class CustomerManager
        {

            public void SendMessage()
            {


                Console.WriteLine("Hello");

            }

            public void ShowAlert()
            {


                Console.WriteLine("Be Careful!");

            }


            public void SendMessage2(string message)
            {


                Console.WriteLine("Hello");

            }

            public void ShowAlert2(string alert)
            {


                Console.WriteLine("Be Careful!");

            }


        }

        class Matematik
        {

            public int Topla(int sayi1, int sayi2)
            {

                return sayi1 + sayi2;

            }

            public int Carp(int sayi1, int sayi2)
            {

                return sayi1 + sayi2;

            }
        }


    }
}
