using GenericList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericListClass<int> testList = new GenericListClass<int>(new int[10] { 2, 1, 2, 3, 4, 5, 6, 7, 8, 2 });
            Console.WriteLine("Testing the Add method");
            testList.Add(15);
            testList.PrintList();
            Console.ReadLine();

            Console.WriteLine("Testing the Remove method");
            testList.Remove(2);
            testList.PrintList();
            Console.ReadLine();

            Console.WriteLine("Testing the Count method");
            Console.WriteLine(testList.Count());

            Console.WriteLine("Testing the iterable-ness of the class");
            foreach (int item in testList)
            {
                Console.WriteLine("Hello World");
                Console.ReadLine();
            }

            //Console.WriteLine(testList.ToString());
            //Console.ReadLine();

            Console.WriteLine("Testing the ToString method");
            string newstring = testList.ToString();
            Console.WriteLine(newstring);
            Console.ReadLine();

            //testing objects

            Lemon lemoner = new Lemon("Kishoree");
            Lemon lemonest = new Lemon("Ashok");
            Lemon lemony = new Lemon("Forest");
            Lemon orange = new Lemon("Vikrum");
            Lemon lime = new Lemon("Mira");
            GenericListClass<Lemon> TestLemonList = new GenericListClass<Lemon>((new Lemon[4] { lemoner, lemonest, lime, lemony }));
            Console.WriteLine("Testing the Add method");
            TestLemonList.Add(orange);
            Console.WriteLine(TestLemonList.Count());

            Console.ReadLine();

            Console.WriteLine("Testing the Remove method");
            TestLemonList.Remove(lime);
            Console.WriteLine(TestLemonList.Count());

            Console.ReadLine();

            Console.WriteLine("Testing the ToString method");
            string newerString = TestLemonList.ToString();
            Console.WriteLine(newerString);
            Console.ReadLine();

            Console.WriteLine("Testing the Count method");
            Console.WriteLine(TestLemonList.Count());
            Console.ReadLine();

            Console.WriteLine("Testing the foreach");
            foreach (Lemon item in TestLemonList)
            {
                Console.WriteLine(orange.priceLemon);
            }
            Console.ReadLine();




        }
    }
}
