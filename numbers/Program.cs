using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    class Program
    {
       
        public static void OddNumbers()
        {

            IEnumerable<int> number = Enumerable.Range(1, 20).Select(x => x * x).Where(x => x % 2 != 0);
            //foreach (int num in number)
            //{
            //    Console.WriteLine(num );
            //}


            var QSCount = (from odd in number
                           select odd).Count();

            var QSSum = (from odd in number
                           select odd).Sum();

            var QSAvarage = (from odd in number
                         select odd).Average();


            var QSMinimum = (from odd in number
                             select odd).Min();


            var QSMaximum = (from odd in number
                             select odd).Max();


            Console.WriteLine("Odd numbers Count " + QSCount);
            Console.WriteLine("Odd numbers Sum " + QSSum);
            Console.WriteLine("Odd numbers Avarage " + QSAvarage);
            Console.WriteLine("Odd numbers Minimum " + QSMinimum);
            Console.WriteLine("Odd numbers AvarMaximumage " + QSMaximum);

        }


        public static void EvenNumbers()
        {
            IEnumerable<int> number = Enumerable.Range(1, 20).Select(x => x * x).Where(x => x % 2 == 0);

           

            //foreach (int num in number)
            //{
                
            //    Console.WriteLine(num);
            //}

            var QSCount = (from even in number
                           select even).Count();

            var QSSum = (from even in number
                         select even).Sum();

            var QSAvarage = (from even in number
                             select even).Average();


            var QSMinimum = (from even in number
                             select even).Min();


            var QSMaximum = (from even in number
                             select even).Max();


            Console.WriteLine("Even numbers Count " + QSCount);
            Console.WriteLine("Even numbers Sum " + QSSum);
            Console.WriteLine("Even numbers Avarage " + QSAvarage);
            Console.WriteLine("Even numbers Minimum " + QSMinimum);
            Console.WriteLine("Even numbers AvarMaximumage " + QSMaximum);


        }



        static void Main(string[] args)
        {
            IEnumerable<int> number = Enumerable.Range(1, 20).Select(x => x * x);
            foreach (int num in number)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");

            Console.WriteLine("Even numbers");
            EvenNumbers();
            Console.WriteLine("");

            Console.WriteLine("Odd numbers");
            OddNumbers();

            Console.ReadLine();

        }
    }
}
