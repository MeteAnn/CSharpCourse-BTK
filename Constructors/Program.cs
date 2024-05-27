using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {

            CustomersManager customersManager = new CustomersManager(); //Burada açtığımız parantez constructor çalıştırır.

            customersManager.List();


            Product product = new Product { ID=1, Name="Laptop"};

            Product product1 = new Product(1,"Computer");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 19;
            Utilities.Validate();
            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();



        }

    }

    class CustomersManager
    {

        private int _count=15;

        public CustomersManager(int count) 
        {

            
            _count = count;
        
        
        }

        public CustomersManager()
        {
                
        }


        public void List()
        {

            Console.WriteLine("Listed! {0}", _count);


        }

        public void Add()
        {

            Console.WriteLine("Added!");


        }


    }
    class Product
    {
        public Product()
        {
            

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;

            _name = name;

        }
        public int ID { get; set; }
        public string Name { get; set; }
    }


    interface ILogger
    {

        void Log();


    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logget to database");
        }
    }

    class FileLogger : ILogger

    {
        public void Log()
        {
            Console.WriteLine("logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {

            _logger = logger;

        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }

    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {

            _entity = entity;

        }
        public void Message()
        {

            Console.WriteLine("{0} message");


        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
                
        }

        public void Add()
        {


            Console.WriteLine("Added!");
            Message();
        }
    }
   
    static class Teacher //statik nesnelerde hiç bir zaman instance oluşturulamaz
    {


        public static int Number { get; set; }

    }

    static class Utilities
    {
        static Utilities()
        {



        }
        public static void Validate()
        {

            Console.WriteLine("Validation is done");

        }
    }

    class Manager
    {

        public static void DoSomething()
        {

            Console.WriteLine("done");

        }
        public void DoSomething2()
        {

            Console.WriteLine("Done2");

        }
    }

    


}
