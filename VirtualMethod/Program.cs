using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlServer sqlserver = new SqlServer();
            sqlserver.Add();

            MySql mysql = new MySql();
            mysql.Delete();

            Console.ReadLine();

        }
        
    }

    class Database
    {


        public virtual void Add()
        {

            Console.WriteLine("Added by default");

        }

        public virtual void Delete()
        {

            Console.WriteLine("Deleted by Default");

        }

    }
    class SqlServer:Database
    {

        public override void Add()
        {


            Console.WriteLine("Added by Sql Code");

            //base.Add(); //Burada base demek temeli yani SqlServerin temeli kim Database yani buna base deniyor basein add ni çalıştırıyor.
        }


    }

    class MySql:Database
    {



    }


}
