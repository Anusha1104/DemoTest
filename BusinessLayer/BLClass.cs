using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLClass
    {
        public int Divide(string numerator,string denominator)
        {
            int r = 0, r1 = 0;
            bool n = int.TryParse(numerator, out r);
            bool n1 = int.TryParse(denominator, out r1);
            if (n && n1)
            {
                if (r1 != 0)
                    return r / r1;
                else
                    throw new DivideByZeroException("Cannot divide by zero");
            }
            else
                throw new FormatException("only numbers");
        }


        public int Age(string date)
        {
            DateTime dt = DateTime.Parse(date);
            DateTime today = DateTime.Today;
            int age = (int)today.Subtract(dt).TotalDays / 365;
            if (age < 18 || age > 60)
                throw new CustomException("Age should be less than 18 or greater than 60");
            else
                return age;

        }

    }
}
