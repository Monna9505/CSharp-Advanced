using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public int DifferenceBetweenTwoDates(string date1, string date2)
        {
            DateTime dateOne = DateTime.Parse(date1);
            DateTime dateTwo = DateTime.Parse(date2);
            int result = (int)Math.Abs((dateOne - dateTwo).TotalDays);

            return result;
        }
    }
}
