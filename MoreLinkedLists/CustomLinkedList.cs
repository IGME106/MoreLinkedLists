using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice exercise 15
/// Class Description   : Custom Linked List class
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : March 29, 2018
/// Filename            : CustomLinkedList.cs
/// </summary>

namespace MoreLinkedLists
{
    class CustomLinkedList
    {
        private CustomLinkedNode head;
        private CustomLinkedNode tail;
        private int count;

        public CustomLinkedNode Head
        {
            get { return this.head; }
            set { this.head = value; }
        }

        public CustomLinkedNode Tail
        {
            get { return this.tail; }
            set { this.tail = value; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        /// <summary>
        /// Add a new node to the linked list
        /// </summary>
        /// <param name="inputData">Data to add as a new node</param>
        public void Add(string inputData)
        {
            if (Head == null)
            {
                Head = new CustomLinkedNode(inputData);
                Tail = Head;

                Count++;
            }
            else
            {                
                Tail.Next = new CustomLinkedNode(inputData);                
                Tail = Tail.Next;

                Count++;
            }
        }

        /// <summary>
        /// Print the data contained in the node at the specified index
        /// </summary>
        /// <param name="index">The index of the data requested</param>
        /// <returns></returns>
        public string GetData(int index)
        {
            string returnValue = null;

            CustomLinkedNode current = Head;

            if ((index < 0) || (index >= Count))
            {
                throw new IndexOutOfRangeException("\n*** The index provided is out of bounds, please enter an index >= 0 and < " + Count + " ***\n");
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;                    
                }

                returnValue = current.Data;
            }

            return returnValue;
        }

        /// <summary>
        /// Remove a node and it's data from the list at the specified index
        /// </summary>
        /// <param name="index">Index of node that needs to be removed from the list</param>
        /// <returns></returns>
        public string RemoveAt(int index)
        {
            string returnValue = null;

            CustomLinkedNode current = Head;

            if ((index < 0) || (index >= Count))
            {
                throw new IndexOutOfRangeException("\n*** The index provided is out of bounds, please enter an index >= 0 and < " + Count + " ***\n");
            }
            else if ((index == 0) && (Count > 1))
            {
                returnValue = Head.Data;

                Head = Head.Next;
            }
            else if (index == (Count - 1))
            {
                for (int i = 0; i < (index - 1); i++)
                {
                    current = current.Next;
                }

                returnValue = current.Next.Data;

                Tail = current;
                current.Next = null;
            }
            else
            { 
                for (int i = 0; i < (index - 1); i++)
                {
                    current = current.Next;
                }

                returnValue = current.Next.Data;

                current.Next = current.Next.Next;
            }

            Count--;

            return returnValue;
        }
            
    }
}
