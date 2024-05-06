using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PersonManager personmanager = new PersonManager();
            //Customer customer = new Customer()
            //{
            //    Id = 1,
            //    FirstName = "Mete",
            //    LastName = "Erdem",
            //    Address = "İstanbul"

            //};


            //StudentPerson student = new StudentPerson()
            //{

            //    Id = 1,
            //    FirstName = "Mehmet",
            //    LastName ="Erdem",
            //    Departmant ="İK"
            



            //};

            //personmanager.Add(student);
            //personmanager.Add(customer);

            
            CustomerManager customer = new CustomerManager();


            customer.Add(new OracleCustomerDal());


            Console.ReadLine();


        }
    }



    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }


    }

    class Customer : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Address { get; set; }


    }

    class StudentPerson : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Departmant { get; set; }



    }

    class PersonManager
    {

        public void Add(IPerson person)
        {

            Console.WriteLine(person.FirstName);

        }


    }
    


}
