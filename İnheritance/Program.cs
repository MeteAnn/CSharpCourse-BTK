﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Person[] person = new Person[3]
            {

                new Customer
                {

                    FirstName="Engin"
                 },
                new Student

                 {

                   FirstName="Derin"

                 },

                new Person

                {

                    FirstName="Salih"

                }




               
            };
            foreach (var item in person)
            {


                Console.WriteLine(item.FirstName);

            }

            Console.ReadLine();

        }





    }

    class Person2
    {




    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    class Customer:Person
    {

        public string City { get; set; }


    }

    class Student:Person
    {

        public string Departmant { get; set; }

    }

}
