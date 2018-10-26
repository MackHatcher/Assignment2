using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2.ExtensionMethods
{
    public static class DateTimeExtensionMethod
    {
        static public int ToAge(this DateTime dateOfBirth)
        {
            if (DateTime.Today.Month < dateOfBirth.Month ||
                DateTime.Today.Month == dateOfBirth.Month &&
                DateTime.Today.Day < dateOfBirth.Day) {
                return DateTime.Today.Year - dateOfBirth.Year - 1;
            } 
            else {
                return DateTime.Today.Year - dateOfBirth.Year;
            }
            
        }
    }
}