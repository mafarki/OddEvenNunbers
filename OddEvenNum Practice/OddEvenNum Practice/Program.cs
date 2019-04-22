using System;

namespace OddEvenNum_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Number: ");
            string useinput;
            useinput = Console.ReadLine();
            int changed = int.Parse(useinput);


            if (changed % 2 == 0)
            {
                Console.Write(" Entered Number is an Even Number");


            }
            else

                Console.Write(" Eneterd Number is an Odd Number");
            Console.ReadLine();
        }
    }
}