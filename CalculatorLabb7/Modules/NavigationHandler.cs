using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLabb7.Modules {

    public class NavigationHandler {

        public static void NavMenu() {

            bool run = true;
            while (run) {

                //Set / Reset the numbers
                (double num1, double num2) numInput;

                //Change the colour of the text
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                   "\n1. Addition\r\n" +
                   "2. Subtraction\r\n" +
                   "3. Multiplication\r\n" +
                   "4. Division\r\n" +
                   "5. Calculator Logs\r\n" +
                   "6. Exit Application\r\n"
                );
                //Reset colour back to original
                Console.ResetColor();

                //Stores the choice as a byte, tries to parse it
                byte choice;
                if (!byte.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine("\n1-6.");

                switch (choice) {
                    default:
                        Console.WriteLine("Not a valid choice.");
                        break;
                    case 1:
                        //Save the input to the (double num1, double num2)
                        numInput = UserInput.Input();
                        Console.WriteLine(
                            "result : " + CalculatorFunctions.Add(numInput.num1, numInput.num2)
                        );
                        SystemFunctions.PressEnter();
                        break;
                    case 2:
                        numInput = UserInput.Input();
                        Console.WriteLine(
                            "result : " + CalculatorFunctions.Subtract(numInput.num1, numInput.num2)
                        );
                        SystemFunctions.PressEnter();
                        break;
                    case 3:
                        numInput = UserInput.Input();
                        Console.WriteLine(
                            "result : " + CalculatorFunctions.Multiply(numInput.num1, numInput.num2)
                        );
                        SystemFunctions.PressEnter();
                        break;
                    case 4:
                        numInput = UserInput.Input();
                        Console.WriteLine(
                            "result : " + CalculatorFunctions.Divide(numInput.num1, numInput.num2)
                        );
                        SystemFunctions.PressEnter();
                        break;
                    case 5:
                        SystemFunctions sysFuncs = new SystemFunctions();
                        sysFuncs.PrintLogs();
                        SystemFunctions.PressEnter();
                        break;
                    case 6:
                        Console.WriteLine($"\nClosing appliction...");
                        run = false;
                        break;
                }

            }

        }

    }

}
