using System;

namespace Execise
{
    class Stack
    {
        int[] luthfi = new int[25];
        public int i;
        int top;
        public Stack()
        {
            top = -1;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push()
        {

        }
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

    }
    
    
}