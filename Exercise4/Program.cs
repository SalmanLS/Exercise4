using System;

namespace Execise
{
    class Stack
    {
        int[] luthfi = new int[25];
        public int i;
        int top;
        public void Read()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                i = Int32.Parse(s);
                if (i <= 25)
                    break;
                else
                    Console.WriteLine("\n Maksimal elemen adalah 25. \n");
            }
            
        }
        public Stack()
        {
            top = -1;
        }
        bool empty()
        {
            if (top == -1)
                return (true);
            else
                return (false);
        }
        public void push()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("---------------------");
            for (top = 0; top < i; top++)
            {
                Console.Write((top+1)+".");
                string s1 = Console.ReadLine();
                luthfi[top] = Int32.Parse(s1); 
            }
            top = top + 1;
        }
        public void pop()
        {
            Console.WriteLine("\n The popped element is;" + luthfi[top]);
            top = luthfi[top-1];
        }

        public void display()
        {
            
            if(empty())
                Console.WriteLine("\n Stack is empty");
            else
            {
                for (int t = top; t != null; t = t-1)
                {
                    Console.Write(luthfi[t]);
                }
            }
        }
        static void Main(string[] args)
        {
            Stack s = new Stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Menu***\n");
                Console.WriteLine("1. Insert the number in the array");
                Console.WriteLine("2. Push");
                Console.WriteLine("3. Pop");
                Console.WriteLine("4. Display");
                Console.WriteLine("5. Exit");
                Console.Write("\n Enter your choice: ");
                string Input = Console.ReadLine();
                char ch = Convert.ToChar(Input == "" ? "0" : Input);
                switch (ch)
                {
                    case '1':
                        s.Read();
                        break;
                    case '2':
                        s.push();
                        break;
                    case '3':
                        if (s.empty())
                        {
                            Console.WriteLine("\n Still empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '4':
                        s.display();
                        break;
                    case '5':
                        return;
                    default:
                        Console.WriteLine("\n Invalid choice");
                        break;
                    

                }
            }
        }
    }
}