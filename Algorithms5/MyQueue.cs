using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms5
{
    internal class MyQueue
    {
        public class Queue<T> {
            MyNode.Node<T> head;
            MyNode.Node<T> tail;
            int count = 0;
            public void Enqueue(T data) {
                MyNode.Node<T> node = new MyNode.Node<T>(data);
                MyNode.Node<T> tmpNode = tail;
                tail = node;
                if (count == 0)
                {
                    head = tail;
                }
                else {
                    tmpNode.Next = tail;
                }
                count++;

            }
            public T Dequeue() {
                if (count == 0) { 
                    throw new InvalidOperationException("Очередь пуста");
                }
                T output = head.Data;
                head = head.Next;
                count--;
                return output;
            }
            public T First
            {
                get
                {
                    if (Empty)
                    {
                        throw new InvalidOperationException("Очередь пуста");


                    }
                    return head.Data;
                }
                
            }
            public T Last
            {
                get
                {
                    if (Empty)
                    {
                        throw new InvalidOperationException("Очередь пуста");


                    }
                    return tail.Data;
                }

            }
            public int Count() 
            { 
                
                return count; 
            }
            public bool Empty { 
                get 
                { 
                    return count == 0; 
                } 
            
            }
        }
    }
}
