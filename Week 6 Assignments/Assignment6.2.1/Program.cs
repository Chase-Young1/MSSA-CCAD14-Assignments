/*Write a C# program to implement a stack by using array with push and pop operations.*/

namespace Assignment6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Stack stack = new Stack();
          stack.Push(10);
          stack.Push(20);
          stack.Push(30);

          Console.WriteLine("The top element is: " + stack.Pop());
          stack.PrintStack();
        }
    }
    internal class Stack
    {
        const int max = 1000;
        int[] stack = new int[max];
        int top;

        internal bool Push(int x)
        {
            if (top >= max)
            {
                Console.WriteLine("Stack Overflow.");
                return false;
            }
            stack[++top] = x;
            return true;
        }
        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow.");
                return 0;
            }
            else
            {
                return stack[top];
            }
        }
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow.");
                return;
            }
            else
            {
                Console.WriteLine("Items in the stack are");
                for (int i = top; i > 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
