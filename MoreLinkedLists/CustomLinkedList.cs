using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice exersize 14
/// Class Description   : Custom Linked List class
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : March 26, 2018
/// Filename            : CustomLinkedList.cs
/// </summary>

namespace MoreLinkedLists
{
    class CustomLinkedList
    {
        private CustomLinkedNode head;
        private int count;

        public CustomLinkedNode Head
        {
            get { return this.head; }
            set { this.head = value; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        public void Add(string inputData)
        {
            if (Head == null)
            {
                Head = new CustomLinkedNode(inputData);

                Count++;
            }
            else
            {
                CustomLinkedNode current = Head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new CustomLinkedNode(inputData);

                Count++;
            }
        }

        public string GetData(int index)
        {
            string returnValue = null;

            CustomLinkedNode current = Head;

            if ((index < 0) || (index >= Count))
            {
                throw new IndexOutOfRangeException();
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
            
    }
}
