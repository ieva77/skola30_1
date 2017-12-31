using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // izveido kalkulatora objektu

            // paprasīt lietotājam ievadīt ievadi
            Console.WriteLine("please enter darība");
            string input = Console.ReadLine();
            // "1 +5 -4" skaits ir 5 pēdējā simbola pozīcija ir 4 
            // "1+" skaits ir 2 pēdēja pozīcija ir 1
            int result;
            int counter = 0;
            while (counter < input.Length)
            {
                char symbol = input[counter];
                if (symbol == '+')
                {
                    Console.WriteLine("plus");
                }
                else
                {
                    // saglabāt simolu teksta virknē, lai tam
                    // var piekļūt, kad tiek veikta darbība
                    int number;
                    number = Int32.Parse(symbol.ToString());
                    Console.WriteLine("number " + number);

                }

                counter = counter + 1;
            }

            Console.ReadLine();
        }
    }
}
