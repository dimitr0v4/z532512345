using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace z532512345
{
    public class TwoWayLists<T>
    {
        public DoublyNode<T> head;
        public DoublyNode<T> tail;
        public TwoWayLists()
        {
            head = null;
            tail = null;
        }
    
    public void AddFirst(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
        }
        public void AddLast(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous =head ;
                tail = newNode;
            }
        }


        // Премахване на елемент от началото на списъка
        public T RemoveFirst()
        {
            if (head == null)
                throw new InvalidOperationException("List is empty");
            T removedData = head.Data;
            head = head.Next;
            if (head != null)
                head.Previous = null;
            else
                tail = null;
            return removedData;
        }
        // Търсене на елемент по стойност
        public bool Contains(T value)
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(value))
                    return true;
                current = current.Next;
            }
            return false;
        }
        // Проверка за празен списък
        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
