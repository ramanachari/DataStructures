using System;

namespace Stack
{
    class DynamicArrayImplementation
    {
        private Stack stack = new Stack(1);

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
                DoubleArray();
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
                Console.Write(stack.Array[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// O(n) is time complexity 
        /// </summary>
        public void DoubleArray()
        {
            int[] tempArray= new int[stack.Capacity * 2];
            for (int i = 0; i < stack.Capacity; i++)
            {
                tempArray[i] = stack.Array[i];
            }

            stack.Array = tempArray;
            stack.Capacity *= 2;
        }

    }
}
