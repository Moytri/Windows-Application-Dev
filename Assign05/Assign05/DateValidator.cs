using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign05
{
    class DateValidator
    {
        public static bool Validate(string year, string month, string day)
        {
            var result = false;

            bool isValidYear = int.TryParse(year, out int myYear);

            bool isValidMonth = int.TryParse(month, out int myMonth);

            bool isValidDay = int.TryParse(day, out int myDay);



            return result;
        }

        private static bool isValidDate(int year, int month, int day)
        {
            bool result;

            try
            {
                var constructedDate = new DateTime(year, month, day);
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }
    }
}
