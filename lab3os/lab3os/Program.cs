using System;
using System.Collections.Generic;

namespace lab3os
{

class GFG
    {
        static void stack_push(Stack<int> stack)
        {
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }
        }

        
        static void stack_pop(Stack<int> stack)
        {
            Console.WriteLine("Pop :");

            for (int i = 0; i < 5; i++)
            {
                int y = (int)stack.Pop();
                Console.WriteLine(y);
            }
        }

    
        static void stack_peek(Stack<int> stack)
        {
            int element = (int)stack.Peek();
            Console.WriteLine("Element on stack top : " + element);
        }

       
        static void stack_search(Stack<int> stack, int element)
        {
            bool pos = stack.Contains(element);

            if (pos == false)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element is found at position " + pos);
        }

        public static void Main(String[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack_push(stack);
            stack_pop(stack);
            stack_push(stack);
            stack_peek(stack);
            stack_search(stack, 2);
            stack_search(stack, 6);
        }
    }

}

