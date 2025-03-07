using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z532512345
{
    internal class Reverse<T>
    {public static DoublyNode<T> Reverser(DoublyNode<T> head)
        {
       if(head==null||head.Next==null)
                return head;
       Node<T> prevNode=null;
            Node<T> currNode=head;
            while(currNode!=null)
            { prevNode=currNode.Previous;
                currNode.Previous=currNode.Next;
                currNode.Next=prevNode;
                currNode=currNode.Previous; }
            head=prevNode.Previous;
            return head;
            //DoublyNode<T> current = rev.head;
            //while (current != null)
            //{(current.Previous,current.Next)=(current.Next,current.Previous);
            //    current=current.Next;}
            //(rev.head,rev.tail)=(rev.tail,rev.head);
         }
        public static void Print(TwoWayLists<T> rev)
        {
            DoublyNode<T> current = rev.head;
            while (current != null)
            {  Console.WriteLine(current.Data+"=>");
               
                current = current.Next;
            }
        }
} }
