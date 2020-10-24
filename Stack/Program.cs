using System;

namespace Stack
{
    static class Program
    {
        static void Main(string[] args)
        {
            //StackUsingSimpleArray();
            //StackUsingDynamicArray();
            StackUsingLinkedList();
        }

        static void StackUsingSimpleArray()
        {
            int choice;
            char ch;
            int data;
            StackUsingArray stack = new StackUsingArray();
            do
            {

                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Delete Stack");
                Console.WriteLine("5. Size");

                Console.WriteLine("<<< Enter Choice >>>");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter data");
                        data = Convert.ToInt32(Console.ReadLine());
                        stack.Push(data);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        stack.Peek();
                        break;
                    case 4:
                        stack.Delete();
                        break;
                    case 5:
                        stack.Size();
                        break;
                }
                Console.WriteLine("Stack Elements are: ");
                stack.PrintStack();

                Console.WriteLine("Press 0 to Exit");
                ch = Console.ReadLine()[0];

            } while (ch != '0');
        }

        static void StackUsingDynamicArray()
        {
            int choice;
            char ch;
            int data;
            DynamicArrayImplementation stack = new DynamicArrayImplementation();
            do
            {

                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Delete Stack");
                Console.WriteLine("5. Size");

                Console.WriteLine("<<< Enter Choice >>>");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter data");
                        data = Convert.ToInt32(Console.ReadLine());
                        stack.Push(data);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        stack.Peek();
                        break;
                    case 4:
                        stack.Delete();
                        break;
                    case 5:
                        stack.Size();
                        break;
                }
                Console.WriteLine("Stack Elements are: ");
                stack.PrintStack();

                Console.WriteLine("Press 0 to Exit");
                ch = Console.ReadLine()[0];

            } while (ch != '0');
        }

        static void StackUsingLinkedList()
        {
            int choice;
            char ch;
            int data;
            StackUsingLinkedList stack = new StackUsingLinkedList();
            do
            {

                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Delete Stack");
                Console.WriteLine("5. Size");

                Console.WriteLine("<<< Enter Choice >>>");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter data");
                        data = Convert.ToInt32(Console.ReadLine());
                        stack.Push(data);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        stack.Peek();
                        break;
                    case 4:
                        stack.Delete();
                        break;
                    case 5:
                        stack.Size();
                        break;
                }
                Console.WriteLine("Stack Elements are: ");
                stack.Print();

                Console.WriteLine("Press 0 to Exit");
                ch = Console.ReadLine()[0];

            } while (ch != '0');
        }
    }
}

