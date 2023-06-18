using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLabb7.Modules {

    public class CalculatorFunctions {

        public static SystemFunctions sysFuncs = new SystemFunctions();

        public static double Add(double x, double y) {
            sysFuncs.LogCalcutlator(x, y, '+', x + y);
            return x + y;
        }
        
        public static double Subtract(double x, double y) {
            sysFuncs.LogCalcutlator(x, y, '-', x - y);
            return x - y;
        }

        public static double Multiply(double x, double y) {
            sysFuncs.LogCalcutlator(x, y, '*', x * y);
            return x * y;
        }

        public static double Divide(double x, double y) {
            sysFuncs.LogCalcutlator(x, y, '/', Math.Round(x / y, 2));
            return Math.Round(x / y, 2);
        }

    }

}
