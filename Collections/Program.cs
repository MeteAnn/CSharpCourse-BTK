using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Tokat");


            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { Id = 1, FirstName="Mete" });
            customers.Add(new Customer { Id = 2, FirstName = "MeteErdem" });

            foreach (var customer1 in customers)
            {
                Console.WriteLine(customer1.FirstName);
            }


            var count = customers.Count;

            var customer2 = new Customer
            {

                Id = 3,
                FirstName = "MeteAn"

            };

            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {

                new Customer { Id = 4, FirstName="Ayşe"},

                new Customer { Id=  5, FirstName ="Ali"}


            });

            Console.WriteLine(customers.Contains(customer2));


            var ındex2= customers.LastIndexOf(customer2); //Aramaya sondan başlar

            Console.WriteLine("Index : {0}", ındex2);

            customers.Insert(0, customer2);

            //customers.Remove(customer2);


            customers.RemoveAll(c => c.FirstName == "Salih");

            //customers.Clear();

            var ındex=customers.IndexOf(customer2);
            Console.WriteLine("ındex : {0}", ındex);

            Console.WriteLine("Count: {0}", count);


            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("book","kitap");
            dictionary.Add("Computer","Bilgisayar");

            Console.WriteLine(dictionary["book"]);


            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key[0]);
            }

            dictionary.ContainsKey("glass"); //sende glass diye bir şey var mı deriz ama yoktur o yüzden false döndürür.

            dictionary.ContainsKey("book"); //bu true döner çünkü book anahtarı vardır.


            Console.ReadLine();
        
        
        }



        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Tokat");




            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            //Console.WriteLine(cities[2]);


            foreach (var item in cities)
            {

                Console.WriteLine(item);


            }
        }
    }

    class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
    }


}
