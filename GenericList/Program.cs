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
            
            GenericListClass<int> testList = new GenericListClass<int>(new int[10] {1,2,3, 2, 2, 4, 5, 6, 7, 8});

            testList.Add(15);
            testList.PrintList();
            Console.ReadLine();
            testList.Remove(2);
            testList.PrintList();
            Console.ReadLine();
            Console.WriteLine(testList.Count());

            foreach (int item in testList)
            {
                Console.WriteLine("Hello World");
                Console.ReadLine();
            }

            testList.PrintString();
            Console.ReadLine();

        }
    }
}
