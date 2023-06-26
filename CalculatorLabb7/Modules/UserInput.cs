using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLabb7.Modules {

    public class UserInput {

        public static (double num1, double num2) Input() {

            double num1;
            double num2;

            while (true) {

                Console.WriteLine("Number 1:");
                if (!double.TryParse(Console.ReadLine(), out num1)) {
                    Console.WriteLine("\nNot a valid input...");
                    //Incase the user inputs an non-valid input, redo this while loop
                    continue;
                }
                   
                Console.WriteLine("Number 2:");
                if (!double.TryParse(Console.ReadLine(), out num2)) {
                    Console.WriteLine("\nNot a valid input...");
                    continue;
                }

                break;
            }

            return (num1, num2);

        }

    }

}
