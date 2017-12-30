using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // izveidot kalkulēšanas objektu
            calculations calc;
            calc = new calculations();

            // paprasīt lietotājam vērtīu
            int firstNumber = calc.AskUserForNumber();

            // paprasīt otru vērtību
            int secondNumber = calc.AskUserForNumber();

            // saskaita
            int result = firstNumber + secondNumber;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
