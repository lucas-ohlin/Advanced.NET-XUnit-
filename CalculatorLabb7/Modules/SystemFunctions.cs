using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLabb7.Modules {

    public class SystemFunctions {

        //Can be read from outside of this class but can only be modified here
        public static List<string> CalculatorList { get; private set; } = new List<string>();

        public void LogCalcutlator(double num1, double num2, char oprtr, double res) {
            //Style of the information saved to the list
            string log = $"{num1} {oprtr} {num2} = {res}";
            CalculatorList.Add(log);
            Console.WriteLine(log);
        }

        public void PrintLogs() {
            //For each item/line in the list print
            foreach (string item in CalculatorList) {
                Console.WriteLine(item);
            }
        }

        public static void PressEnter() {
            Console.WriteLine("\nENTER to continue...");
            //Until the user presses enter this won't continue
            ConsoleKeyInfo x;
            do { 
                x = Console.ReadKey(); 
            }
            while (x.Key != ConsoleKey.Enter);
            //Clear the console as well
            Console.Clear();
        }

    }

}
