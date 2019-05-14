using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslem
{
    public static class NumericCheck
    {
        public static bool IsNumeric(this string value)
        {
            double oReturn = 0;
            return double.TryParse(value, out oReturn);
        }
    }
}
