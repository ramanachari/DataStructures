using System;

namespace Stack
{

    class Stack
    {
        public int Capacity { get; set; }
        public int Top { get; set; }
        public int[] Array { get; set; }
        public Stack(int capacity)
        {
            Capacity = capacity;
            Top = -1;
            Array = new int[capacity];
        }
    }

    class StackUsingArray
    {

        private Stack stack = new Stack(5);

        //Is Empty
        /// <summary>
        /// O(1) is time complexity 
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return stack.Top == -1;
        }

        //Is Full
        /// <summary>
        /// O(1) is time complexity 
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return stack.Capacity == stack.Top + 1;
        }

        //Push
        /// <summary>
        /// O(1) is time complexity 
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            if (IsFull())
            {
                Console.WriteLine("Sorry!!! Stack is Full...");
                return;
            }
            stack.Array[++stack.Top] = data;
        }

        //Pop
        /// <summary>
        /// O(1) is time complexity 
        /// </summary>
        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Sorry!!! Stack is Empty...");
                return;
            }
            Console.WriteLine("{0} is Poped from stack", stack.Array[stack.Top--]);
        }

        //Peek
        /// <summary>
        /// O(1) is time complexity 
        /// </summary>
        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Sorry!!! Stack is Empty...");
                return;
            }
            Console.WriteLine("{0} is top element in stack", stack.Array[stack.Top]);
        }

        //Delete Stack
        /// <summary>
        /// O(1) is time complexity 
        /// </summary>
        public void Delete()
        {
            stack = new Stack(stack.Capacity);
        }

        //Size
        /// <summary>
        /// O(1) is time complexity 
        /// </summary>
        public void Size()
        {
            Console.WriteLine("Stack size is: {0}", stack.Top + 1);
        }


        /// <summary>
        /// O(n) is time complexity 
        /// </summary>
        public void PrintStack()
        {
            if (IsEmpty())
            {
                return;
            }
            
            for (int i = 0; i <= stack.Top; i++)
            {
                Console.Write(stack.Array[i]+" ");
            }
            Console.WriteLine();
        }

    }
}
