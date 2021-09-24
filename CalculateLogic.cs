using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp
{
    static class CalculateLogic
    {
        static public string ChooseOperation(Operation op, string s1, string s2)
        {
            if ((int)op == 1)
            {
                return Sum(s1, s2);
            }
            else if ((int)op == 2)
            {
                return Sub(s1, s2);
            }
            else if ((int)op == 3)
            {
                return Mult(s1, s2);
            }
            else
            {
                return Div(s1, s2);
            }
        }


        static public string Sum(string s1, string s2)
        {
            double numb1 = double.Parse(s1, CultureInfo.InvariantCulture);
            double numb2 = double.Parse(s2, CultureInfo.InvariantCulture);
            return (numb2 + numb1).ToString(CultureInfo.InvariantCulture);
        }

        static public string Sub(string s1, string s2)
        {
            double numb1 = double.Parse(s1, CultureInfo.InvariantCulture);
            double numb2 = double.Parse(s2, CultureInfo.InvariantCulture);
            return (numb2 - numb1).ToString(CultureInfo.InvariantCulture);
        }

        static public string Mult(string s1, string s2)
        {
            double numb1 = double.Parse(s1, CultureInfo.InvariantCulture);
            double numb2 = double.Parse(s2, CultureInfo.InvariantCulture);
            return (numb2 * numb1).ToString(CultureInfo.InvariantCulture);
        }
        static public string Div(string s1, string s2)
        {
            double numb1 = double.Parse(s1, CultureInfo.InvariantCulture);
            double numb2 = double.Parse(s2, CultureInfo.InvariantCulture);
            return (numb2 / numb1).ToString(CultureInfo.InvariantCulture);
        }

    }
}
