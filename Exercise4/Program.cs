using System;

namespace Execise
{
    class StackUsingArray
    {
        int[] luthfi = new int[25];
        int i;

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
    class Stack
    {

    }
    
}