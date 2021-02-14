using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head ;
        public Node lastNode;
        /// <summary>
        /// UC-2 Appending elements
        /// </summary>
        /// <param name="new_data"></param>
//        public void Append(int new_data)
//        {
//            Node new_node = new Node(new_data);
//            if (this.head != null)
//            {
//                lastNode = GetLastNode();
//                lastNode.next = new_node;
//            }
//            else
//            {
//                this.head = new_node;
//            }
            //Console.WriteLine("Inserted into list " + new_node.data);
//        }

//        public Node GetLastNode()
//        {
//            Node temp = this.head;
//            while (temp.next != null)
//            {
//                temp = temp.next;
//            }
//            return temp;
//        }

//        public void Add(int new_data)
//        {
//            Node new_node = new Node(new_data);
//            new_node.next = this.head;
//            this.head = new_node;

//        }

//        public void Display()
//        {
//            Console.WriteLine("Displaying Nodes");
//            Node temp = this.head;
//            if ( temp == null)
//            {
//                Console.WriteLine("LinkedList is empty");
//            }
//            else
//            {
//                while (temp != null)
//                {
//                    Console.WriteLine(" " + temp.data);
//                    temp = temp.next;
//                }
//
//            }
//        }
//    }
//}
