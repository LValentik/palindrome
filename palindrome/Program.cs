using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string c = x.ToString();
            int x2 = x;
            int s = 0;
            if (x < 0)
            {
                Console.WriteLine("Vaše číslo není palindrom");
            }
            else
            {
                for (int i = 0; i < c.Length; i++)
                {
                    s = (s * 10) + (x % 10);
                    x = x / 10;
                    Console.WriteLine(s);
                }
                if (s == x2)
                {
                    Console.WriteLine("Vaše číslo je palindrom");

                }

                else
                {
                    Console.WriteLine("Vaše číslo není palindrom");
                }

            }
            Console.ReadLine();




        }
    }
}
