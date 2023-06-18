using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLabb7.Modules {

    public class UserInput {

        public static (double num1, double num2) Input() {

            while (true) {

                Console.WriteLine("Number 1:");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                    Console.WriteLine("\nNot a valid input...");

                Console.WriteLine("Number 2:");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                    Console.WriteLine("\nNot a valid input...");

                return (num1, num2);

            }

        }

    }

}
