﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer { Id = 1, LastName = "Engin", Age = 22 };


            CustomerDal customerdal = new CustomerDal();

            customerdal.Add(customer);

            Console.ReadLine();

        }

        [ToTable("Customers")]
        class Customer
        {

            public int Id { get; set; }

            [RequiredProperty]
            public string FirstName { get; set; }
            [RequiredProperty]
            public string LastName { get; set; }

            [RequiredProperty]
            public int Age { get; set; }


        }


        class CustomerDal
        {

            [Obsolete("Don't use Add, İnstead use AddNew Method")]
            public void Add(Customer customer)
            {

                Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName,customer.LastName);



            }
            public void AddNew(Customer customer)
            {

                Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName);



            }


        }


        [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
        class RequiredPropertyAttribute:Attribute
        {




        }


        [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
        class ToTableAttribute:Attribute
        {

            private string _tableName;

            public ToTableAttribute(string tableName)
            {

                _tableName = tableName;


            }



        }

        



    }   

}
