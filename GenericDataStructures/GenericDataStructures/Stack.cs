using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CACTB.GenericDataStructures
{
    public class Stack<T>
    {
        int Index;
        T[] Container;
        int Size;
        public Stack(int size)
        {
            Size = size;
            Container = new T[size];
            Index = -1;
        }
       public T Pop()
        {
            if (Index == -1)
                throw new Exception("Stack is Empty!");
            else return Container[Index--];
        }
        public void Push(T element)
        {
            if (Index == Size)
                throw new Exception("Stack is Full!");
            else
            {
                Index++;
                Container[Index] = element;
            }
        }
    }
   
}