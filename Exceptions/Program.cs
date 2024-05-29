using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string[] student = new string[3]
           {

                "Engin",
                "Derin",
                "Salih"

           };

                student[3] = "Ahmet";
            }

            catch (IndexOutOfRangeException exception)
            {

                Console.WriteLine( exception.InnerException);

            }
            catch (DivideByZeroException exception)
            {   

                Console.WriteLine(exception.Message);

            }

            catch (Exception exception)
            {

                Console.WriteLine(exception.InnerException);
            }


            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                
            }

            catch(Exception exception)
            {



            }

            
            HandleException(() =>
            {


                Find();
            
            
            });



            Console.ReadLine();


        }


        private static void HandleException(Action action)
        {


            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }


        }


        private static void Find()
        {

            List<string> students = new List<string>
            {

                "Engin", "Derin", "Salih"


            };

            if (!students.Contains("Ahmet"))
            {

                throw new RecordNotFoundException("Record Not Found!");

            }
            else
            {
                Console.WriteLine("Record Found");
            }



        }


    }
}
