using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice exercise 14
/// Class Description   : Main program
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : March 26, 2018
/// Filename            : Program.cs
/// </summary>

namespace MoreLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList myList = new CustomLinkedList();

            myList.Add("Data 1");
            myList.Add("Data 2");
            myList.Add("Data 3");
            myList.Add("Data 4");
            myList.Add("Data 5");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(myList.GetData(i));
            }

            Console.WriteLine();

            Console.WriteLine("The value at index 1 (position 2) is " + myList.GetData(1));

            Console.ReadKey();
        }
    }
}
