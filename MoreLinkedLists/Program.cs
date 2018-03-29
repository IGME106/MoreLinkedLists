using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice exercise 15
/// Class Description   : Main program
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : March 29, 2018
/// Filename            : Program.cs
/// </summary>

namespace MoreLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList myList = new CustomLinkedList();                               // Create custom linked list

            myList.Add("Data 1");                                                           // Add data to list
            myList.Add("Data 2");
            myList.Add("Data 3");
            myList.Add("Data 4");
            myList.Add("Data 5");
            myList.Add("Data 6");

            try
            {
                for (int i = 0; i < myList.Count; i++)                                      // Print data in list
                {
                    Console.WriteLine(myList.GetData(i));
                }

                Console.WriteLine();                                                        // Perform actions requested by assignment
                Console.WriteLine("Calling delete method as described in the assignment");
                Console.WriteLine();
                //Console.WriteLine("Deleting invalid node -1 (the last node at index 5)...       " + myList.RemoveAt(-1) + " was deleted");
                Console.WriteLine();
                Console.WriteLine("Deleting node 6 (the last node at index 5)...       " + myList.RemoveAt(5) + " was deleted");
                Console.WriteLine();
                Console.WriteLine("Deleting node 1 (the first node at index 0)...       " + myList.RemoveAt(0) + " was deleted");
                Console.WriteLine();
                Console.WriteLine("Deleting node 3 (the second node at index 2)...       " + myList.RemoveAt(2) + " was deleted");
                Console.WriteLine();
                Console.WriteLine("  Printing list for confirmation");
                Console.WriteLine("----------------------------------");

                for (int i = 0; i < myList.Count; i++)                                      // Reprint list
                {
                    Console.WriteLine("Index : " + i + "          Value : " + myList.GetData(i));
                }
            }
            catch (IndexOutOfRangeException e)                                              // Catch invalid index exception
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
