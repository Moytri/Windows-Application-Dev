using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign05
{
    /// <summary>
	/// DateValidator class for Date validation;
    /// For the valid year, month, and date, check whether input is a valid date or not.
    /// For invalid user input Validate method returns flase
	/// </summary>
    class DateValidator
    {
        public static bool Validate(string year, string month, string day)
        {
            var result = false;

            bool isValidYear = int.TryParse(year, out int myYear);

            bool isValidMonth = int.TryParse(month, out int myMonth);

            bool isValidDay = int.TryParse(day, out int myDay);

            if(isValidYear && isValidMonth && isValidDay)
            {
                result = isValidDate(myYear, myMonth, myDay);
            }

            return result;
        }

        private static bool isValidDate(int year, int month, int day)
        {
            bool result;

            try
            {
                var constructedDate = new DateTime(year, month, day);
                if(year < 1900)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
               
            }
            catch
            {
                result = false;
            }
            return result;
        }
    }
}
