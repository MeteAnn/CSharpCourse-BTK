using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {


        void Add();
        void Update();

        void Delete();  



    }

   public class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    public class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Oracle");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Oracle");
        }

        public void Update()
        {
            Console.WriteLine("Sql Oracle");
        }

      
    }


    public class CustomerManager
    {

        public void Add(ICustomerDal customerDal)
        {

            customerDal.Add();

        }




    }



















}
