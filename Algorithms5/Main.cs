using Algorithms5;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;

internal class Programm {

    public static float GetMemory()
    {
        Process c_p = System.Diagnostics.Process.GetCurrentProcess();
        string prcName = Process.GetCurrentProcess().ProcessName;
        var counter_Exec = new PerformanceCounter("Process", "Working Set - Private", prcName);
        double dWsp_Exec = (double)counter_Exec.RawValue; // < ---that is the value in KB
        float m_u = (float)dWsp_Exec /(1024*1024);
        return m_u;
    }

    static void Main(string[] args) {
        MyStack.Stack<int> stack1 = new MyStack.Stack<int>();
        MyStack.Stack<int[]> stack2 = new MyStack.Stack<int[]>();
        //MyQueue.Queue<int> queue1 = new MyQueue.Queue<int>();
        MyDoublyList.DoublyList<int> list1 = new MyDoublyList.DoublyList<int>();
        int[] a = new int[10000000];
        int[] b = new int[10000000];
        for (int i = 0; i < 1000000; i++)
        {
            a[i] = i;
            b[i] = -i;
        }
        stack1.Push(1);
        stack1.Push(2);
        stack1.Push(3);
        stack1.Pop();
        stack2.Push(a);
        stack2.Push(b);
        stack2.Push(a);
        stack2.Push(b);
        stack2.Push(b);
        stack2.Pop();
        Console.WriteLine(stack1.Peek());
        Console.WriteLine(GetMemory()); 
        Console.ReadKey();
    
    }

}