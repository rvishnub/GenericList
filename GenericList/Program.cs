using GenericList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            GenericListClass<int> testList = new GenericListClass<int>(new int[10] {0,0,0,0,0,0,0,0,0,0 });

            for (int i = 0; i<10; i++)
            {
                int milliseconds = 500;
                Thread.Sleep(milliseconds);
                int j = rnd.Next();
                testList.Add(j);
            }


            Console.WriteLine("This is the first list:");
            testList.PrintList();
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Testing the Add method");
            Console.WriteLine("Add {0}.", "15");
            testList.Add(15);
            testList.PrintList();
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Testing the Remove method");
            Console.WriteLine("Remove {0}.", "2");
            testList.Remove(2);
            testList.PrintList();
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Testing the Count property");
            Console.WriteLine(testList.Count);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Testing the iterable-ness of the class");
            foreach (int item in testList)
            {
                Console.WriteLine("Printing "+item);
            }
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Testing the ToString method");
            string newstring = testList.ToString();
            Console.WriteLine(newstring);
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Overloading the operator '+'");
            Console.WriteLine("Here is the list to add:  ");
            GenericListClass<int> List2 = new GenericListClass<int>(new int[4] { 6, 7, 8, 9 });
            List2.PrintList();
            GenericListClass<int> ThirdList;
            ThirdList = testList + List2;
            Console.WriteLine("Here is the new list;");
            ThirdList.PrintList();
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Overloading the operator '-'");
            Console.WriteLine("Here is the list to subtract:  ");
            GenericListClass<int> FourthList;
            GenericListClass<int> List3 = new GenericListClass<int>(new int[4] { 3, 4, 6, 15 });
            List3.PrintList();
            FourthList = ThirdList - List3;
            Console.WriteLine("Here is the new list;");
            FourthList.PrintList();
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Zipping two lists, one longer than the other.");
            GenericListClass<string> NewList = new GenericListClass<string>(new string[5] { "A", "B", "C", "D", "E" });
            GenericListClass<string> OldList = new GenericListClass<string>(new string[7] { "AA", "BB", "CC", "DD", "EE", "FF", "GG" });
            NewList.PrintList();
            Console.WriteLine();

            OldList.PrintList();
            GenericListClass<string> FifthList;
            FifthList = NewList.Zip(OldList);
            Console.ReadLine();
            Console.WriteLine("The zipped list:");

            FifthList.PrintList();
            Console.WriteLine();

            Console.ReadLine();

            GenericListClass<int> testList2 = new GenericListClass<int>(new int[10] { 2, 1, 2, 3, 4, 5, 6, 7, 8, 2 });

            Console.WriteLine("Here is the int list to sort:");
            testList2.PrintList();
            Console.WriteLine();
            testList2.Sort();
            testList2.PrintList();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Here is the string list to sort:");
            GenericListClass<string> testList3 = new GenericListClass<string>(new string[10] { "a", "s", "g", "e", "u", "v", "d", "m", "g", "w" });
            testList3.PrintList();
            testList3.Sort();
            Console.WriteLine();
            testList3.PrintList();
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();



            //testing objects
            Console.WriteLine("Testing sorting objects");
            GenericListClass<decimal> SixthList = new GenericListClass<decimal>(new decimal[] { });
            GenericListClass<Lemon> lemons = new GenericListClass<Lemon>(new Lemon[] { });
            GenericListClass<decimal> SeventhList = new GenericListClass<decimal>(new decimal[] { });


            Console.WriteLine("Here are the lemons.");

            for (int i = 0; i < 10; i++)
            {
                decimal priceLemon = 0;
                Lemon lemon = new Lemon(priceLemon);
                int milliseconds = 500;
                Thread.Sleep(milliseconds);
                lemons.Add(lemon);
                lemon.SetPriceLemon();
                SeventhList.Add(lemon.priceLemon);
                Console.WriteLine(lemon + "    " + lemon.priceLemon + "     " + lemon.label);
            }

            Console.WriteLine("I am sorting the lemons with lemons.Sort().");
            lemons.Sort();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Here are the sorted lemons.");
            foreach (Lemon lemon in lemons)
            {
                Console.WriteLine(lemon + "    " + lemon.priceLemon);
                int milliseconds = 500;
                Thread.Sleep(milliseconds);

            }

            Console.ReadKey();
        }
    }
}
