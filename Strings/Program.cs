using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string city = "Ankara";

            ////Console.WriteLine(city[0]);

            //foreach (var item in city)
            //{


            //    Console.WriteLine(item);
            //}



            //string city2 = "İstanbul";


            //string result = city + city2;



            //Console.WriteLine(String.Format("{0} {1}", city,city2));


            string sentence = "My name is Mete Erdem";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Derin";


            bool result1 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My Name");

            var result5 = sentence.IndexOf("namee");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello,");
            var result9 = sentence.Substring(3,4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();


            Console.WriteLine(result5);

            Console.ReadLine();

        }
    }
}
