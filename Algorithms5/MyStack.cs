using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms5;


namespace Algorithms5
{
    internal class MyStack
    {
        
        public class Stack<T> 
        {
            MyNode.Node<T> head;
            int count=0;
            public int Count()
            {
                return count;
            }

            public void Push(T item)
            {
                MyNode.Node<T> node = new MyNode.Node<T>(item);
                node.Next = head; 
                head = node;
                count++;
            }
            public T Pop()
            {
                if (Empty)
                    throw new InvalidOperationException("Стек пуст");
                MyNode.Node<T> tmp = head;
                head = head.Next; // переустанавливаем верхушку стека на следующий элемент
                count--;
                return tmp.Data;
            }
            public T Peek()
            {
                if (Empty)
                    throw new InvalidOperationException("Стек пуст");
                return head.Data;
            }
            public bool Empty
            {
                get { return count == 0; }
            }

        }

    }
}
