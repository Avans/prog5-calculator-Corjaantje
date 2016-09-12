using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class AgeCalc : IAgeCalculator
    {
        ConsoleView cView;

        public AgeCalc()
        {
            Boolean runTests = false;
            if(!runTests)
            {
                Console.Out.WriteLine("Please give a date in the DD-MM-YYYY Format!");
                DateTime result;
                this.ParseInput(Console.ReadLine(), out result);
                Console.Out.WriteLine("Your age is " + CalculateAge(result) + " years old!");
                Console.Read();
            }
        }

        public int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            return age;
        }

        public bool ParseInput(string input, out DateTime result)
        {          
            if (!DateTime.TryParse(input, out result))
            {
                return false;
            }
            else if(input == null)
            {
                return false;
            }
            else
            {
                return true;
            }      
        }
    }
}
