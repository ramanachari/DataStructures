using System;

namespace Stack
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }

    class StackUsingLinkedList
    {
        public Node top = null;

        //Is Empty
        /// <summary>
        /// O(1) is time complexity
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (top == null)
                return true;
            return false;
        }

        //Size
        /// <summary>
        /// O(n) is time complexity
        /// </summary>
        public void Size()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty...");
                return;
            }
            int count = 0;
            Node curNode = top;
            while (curNode != null)
            {
                count++;
                curNode = curNode.Next;
            }
            Console.WriteLine("Stack size is: {0}",count);
        }

        //push
        /// <summary>
        /// O(1) is time complexity
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        //pop
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
            Console.WriteLine("{0} is poped from stack", top.Data);
            top = top.Next;
        }

        //Delete
        /// <summary>
        /// O(1) is time complexity
        /// </summary>
        public void Delete()
        {
            top = null;
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
            Console.WriteLine("{0} is top element in stack", top.Data);
        }

        //Print elements
        /// <summary>
        /// O(n) is time complexity
        /// </summary>
        public void Print()
        {
            Node curNode = top;
            while (curNode != null)
            {
                Console.Write(curNode.Data + " ");
                curNode = curNode.Next;
            }
            Console.WriteLine();
        }
    }
}
