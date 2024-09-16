using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DortIslem dortislem = new DortIslem(2, 3);
            //Console.WriteLine(dortislem.Topla2());
            //Console.WriteLine(dortislem.Topla(1,2));

            var tip = typeof(DortIslem);

            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);

            //Console.WriteLine(dortIslem.Topla(4,5));
            //Console.WriteLine(dortIslem.Topla2());



            var instance = (DortIslem)Activator.CreateInstance(tip, 6, 7);


            MethodInfo methodınfo = instance.GetType().GetMethod("Topla2");
                
           object result = methodınfo.Invoke(instance,null);

            Console.WriteLine("--------------------");

            var metodlar = tip.GetMethods();

            foreach (var info in metodlar)
            {

                Console.WriteLine(info.Name);

                foreach (var parametreInfo in info.GetParameters())
                {


                    Console.WriteLine(parametreInfo);


                }

                foreach (var attribute in info.GetCustomAttributes())
                {

                    Console.WriteLine(attribute.GetType().Name);

                }


            }


            Console.ReadLine();
        }
    }


    class DortIslem
    {


        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {



            _sayi1 = sayi1;
            _sayi2 = sayi2;
                
        }

        public DortIslem()
        {
                
        }

        public int Topla(int sayi1, int sayi2)
        {



            return sayi1 + sayi2;


        }

        public int Carp(int sayi1, int sayi2)
        {

            return sayi1 * sayi2;

        }


        public int Topla2()
        {



            return _sayi1 + _sayi2;


        }

        [MetodName("Carpma")]
        public int Carp2()
        {

            return _sayi1 * _sayi2;

        }

    }


    class MetodNameAttribute:Attribute
    {


        public MetodNameAttribute(string name)
        {
                
        }

    }


}
