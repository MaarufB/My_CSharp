using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Simple
{
    internal class Node
    {
        internal int data;
        internal Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }

        internal void InsertFront(SingleLinkedList singlyList, int newData)
        {
            Node new_node = new Node(newData);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }

        internal void Insertlast(SingleLinkedList singlyList, int newData)
        {
            Node newNode = new Node(newData);
            if(singlyList.head == null)
            {
                singlyList.head = newNode;
                return;
            }

            Node lastNode = GetLastNode(singlyList);
            lastNode.next = newNode;
           
        }

        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while(temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }

        internal void InsertAfter(Node prevNode, int newData)
        {
            if(prevNode == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }

            Node newNode = new Node(newData);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }

        internal void DeleteNodeByKey(SingleLinkedList singlyList, int key)
        {
            Node temp = singlyList.head;
            Node prev = null;

            if(temp != null && temp.data == key)
            {
                singlyList.head = temp.next;
                return;
            }

            while(temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
                return;

            prev.next = temp.next;
        }

        public void ReverseLinkedList(SingleLinkedList singlyList)
        {
            Node prev = null;
            Node current = singlyList.head;
            Node temp = null;

            while(current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            singlyList.head = prev;
        }
    }
}
