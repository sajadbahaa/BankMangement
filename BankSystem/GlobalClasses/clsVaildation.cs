using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vaildation
{
    public class clsVaildation
    {
        public static bool VaildationEmail(string Text)
        {
            var Pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var rex = new Regex(Pattern);
            return rex.IsMatch(Text);
        }

        public static bool VaildateInger(string Number)
        {
            string pattern = @" ^ [0-9]*$";
            var rex = new Regex(pattern);
            return rex.IsMatch(Number);
        }
        public static bool VaildateFloat(string Number)
        {
            string pattern = @"^[0-9]*(?:\.[0-9]*)?$";
            var rex = new Regex(pattern);
            return rex.IsMatch(Number);
        }
        public static bool IsNumber(string Number)
        {
            return (VaildateInger(Number) || VaildateFloat(Number));
        }
        public static bool IsNum1BiggerThanNum2(int num1, int num2)
        {
            return (num1 > num2);
        }
        public static bool IsNum1SmallerThanNum2(int num1, int num2)
        {
            return (num1 < num2);
        }
        public static bool IsNum1EqualNum2(int num1, int num2)
        {
            return (num1 == num2);
        }
    }
}
