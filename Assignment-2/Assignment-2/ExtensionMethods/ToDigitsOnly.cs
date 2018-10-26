using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2.ExtensionMethods
{
    public static class ToDigitsOnly
    {
        
        public static string ToDigitOnly(this string myString)
        {
            return new string(myString.Where(c => char.IsDigit(c)).ToArray());                        
        }
    }
}