using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Algorithms5.MyNode;

namespace Algorithms5
{
    internal class MyDoublyList
    {
        public class DoublyList<T> {
            MyNode.Node<T> head;
            MyNode.Node<T> tail;
            int count = 0;
            public void Add(T data) {
                MyNode.Node<T> node = new MyNode.Node<T>(data);
                if (head == null)
                {
                    head = node;
                }
                else {
                    tail.Next = node;
                    node.Previous = tail;
                }
                tail = node;
                count++;
            }
            public void AddFirst(T data)
            {
                MyNode.Node<T> node = new MyNode.Node<T>(data);
                MyNode.Node<T> temp = head;
                node.Next = temp;
                head = node;
                if (count == 0)
                    tail = head;
                else
                    temp.Previous = node;
                count++;
            }
            public bool Remove(T data) {
                MyNode.Node<T> current = head;
                while (current != null) {
                    if (current.Data.Equals(data)) {
                        break;
                    
                    }
                }
                if (current != null)
                {
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        tail = current.Previous;
                    }
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }
                    count--;
                    return true;
                }
                return false;
            }
            public void Traverse()
            {
                MyNode.Node<T> current = head;

                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
            }
            public int Count() { return count; }
            public bool Empty { get { return count == 0; } }
        }
    }
}
