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
                Console.WriteLine("Masukkan banyaknya elemen pada Array: ");
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
            Console.WriteLine(-----------------------);
            for(int j = 0; j < i; j++)
            {
                top = top + 1;
                Console.WriteLine((j+1)+".");
                string s1 = Console.ReadLine();
                top = luthfi[j] = Int32.Parse(s1);
            }
        }
        public void pop()
        {
            Console.WriteLine("\n The popped element is;" + luthfi[top]);
            top = -1;
        }

        

    }
    
    
}