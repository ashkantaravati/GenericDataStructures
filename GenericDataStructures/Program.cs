using System;
using CACTB.GenericDataStructures;

namespace CACTB
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfStack;
            Console.WriteLine("Please Enter size of Stack");
           sizeOfStack=int.Parse( Console.ReadLine());
            var stk = new Stack<string>(sizeOfStack);
            string words = Console.ReadLine();
            var x = words.Split(' ');
            foreach (var str in x)
            {
                stk.Push(str);
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(stk.Pop());
            }

            Console.ReadKey();
        }
    }
}
