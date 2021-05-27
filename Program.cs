using System;
using System.Linq;
using System.Collections.Generic;



namespace EnteringNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter integers separated by a space : ");
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();
            foreach (string a in data)
            {
                numbers.Add(Convert.ToInt32(a));
            }
            Console.Write("You entered : \n");
            for (int i = 0; i < numbers.Count(); i++)
            {
                Console.Write(numbers[i] + ", ");
            }
        }
    }
}
