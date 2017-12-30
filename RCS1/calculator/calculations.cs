using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class calculations
    {
        public int AskUserForNumber()
        {
            // izvadīt tekstu kas paprasa ciparu
            Console.WriteLine("please enter number:");
            // ielasīt ciparu no konsoles
            // izveido mainīgo, kas glaās tekstu
            int number;
            // ieraksta mainīgajā ReadLine funkcijas rezultātu
            string inputText = Console.ReadLine();

            // pārveido lietotaja tekstu par ciparu
            bool success  = Int32.TryParse(inputText, out number);

            if (success == false)
            {
                Console.WriteLine("sorry, wrong value entered");
                number = this.AskUserForNumber();
            }

            return number;
        }
    }
}
