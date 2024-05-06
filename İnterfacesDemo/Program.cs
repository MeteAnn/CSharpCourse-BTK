using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfacesDemo
{
     class Program
    {
        static void Main(string[] args)
        {

            IWorker[] workers = new IWorker[3]
            {

                new Manager(),
                new Worker(),
                new Robot()



            };

            foreach (var item in workers)
            {

                item.Work();

            }

            IEat[] eats = new IEat[2];
            {

                new Manager();
                new Worker();   




            };
            foreach (var item in eats)
            {


                item.Eat();


            }
            ISalary[] salary = new ISalary[2]
            {


                new Worker(),
                new Manager()


            };

            foreach (var item in salary)
            {

                item.GetSalary();


            }



        }



        interface IWorker
        {


            void Work();
           
            




        }


        interface IEat
        {

            void Eat();

        }

        interface ISalary
        {


            void GetSalary();



        }



        class Manager : IWorker, IEat, ISalary 
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        

        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }


    }
}
