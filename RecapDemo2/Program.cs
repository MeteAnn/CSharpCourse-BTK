using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            

            customerManager.Add();
            Console.WriteLine("Customer added!");



        }
    }

    class CustomerManager
    {
        public ILogger logger { get; set; }

        public void Add()
        {

            logger.Log();
            Console.WriteLine("Customer Added!");
        }

    }
    class DatabaseLogger:ILogger
    {


        public void Log()
        {


            Console.WriteLine("Logged To Database!");


        }

    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms!");
        }
    }

    interface ILogger
    {


        void Log();


    }

}
