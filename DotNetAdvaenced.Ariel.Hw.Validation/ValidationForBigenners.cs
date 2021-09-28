using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DotNetAdvaenced.Ariel.Hw.Validation
{
    public static class ValidationForBigenners
    {
        #region Targil 1 Validation
        public static bool IsSratD(this string id)
        {
            var expression = @"^D.*";
            return new Regex(expression).IsMatch(id);
        }
        #endregion
        #region Targil 2 + 3 Validation
        public static bool StartWithDFJ(this string str)
        {
            Regex expression = new Regex(@"^[DFJ]\d{6}|\c_\D{2}");
            return expression.IsMatch(str);
        }
        #endregion
        #region Targil 4 
        public static string ExchangeYyy(this string str)
        {
            Regex expressionZ = new Regex(@"זזזז");
            Regex expressionY = new Regex(@"yyy");
            string newString;
            if (expressionZ.IsMatch(str))
            {
                newString = str.Replace('ז', ' ');
                return newString;
            }
            if (expressionY.IsMatch(str))
            {
                newString = str.Replace('y', ' ');
                return newString;
            }
            return str;
        }
        #endregion

        #region Trgil 5 
        public static bool StartWitCapital(this string str)
        {
            Regex expression = new Regex(@"^[A-Z]");
            return expression.IsMatch(str);
        }
        #endregion

        #region Trgil 6
        public static bool ContaionAbc(this string str)
        {
            Regex expression = new Regex(@"ABC|abc");
            return expression.IsMatch(str);
        }
        #endregion

        #region Targil 7
        public static bool FirsAndLastName(this string str)
        {
            Regex expression = new Regex(@"\D{2,18} \D{2,18}");
            return expression.IsMatch(str);
        }
        #endregion
        #region Targil 8 + 9
        public static bool IsDecimalNumber(this double doub)
        {
            Regex expression = new Regex(@"^\d+.\d{3}");
            return expression.IsMatch(doub.ToString());
        }
        #endregion
        #region Targil 10
        public static bool IsValidEmail(this string email)
        {
            Regex expression = new Regex(@"^.+(@)+((yahoo)|(gmail))+.+(com)");
            return expression.IsMatch(email);
        }
        #endregion
    }
}
