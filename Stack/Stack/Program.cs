using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<String> stack = new MyStack<string>();
            stack.Push("Prvi string");
            stack.Push("Drugi string");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine();

            stack.Push("Novi Prvi string");
            stack.Push("Novi Drugi string");
            stack.Push("Novi Treci string");
            stack.Push("Novi Cetvrti string");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.ReadKey();
        }
    }
}
