using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex60ExtensionMethods
{
    public static class StringExtensions
    {

        public static String Shift(this string target, int shift)
        {

            string result = string.Empty;

            result = target.Substring(target.Length - shift);
            result += target.Substring(0, target.Length - shift);

            return result;

        }
        
    }
}
