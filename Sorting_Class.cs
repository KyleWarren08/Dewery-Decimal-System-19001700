using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dewery_Decimal_System_19001700
{
    class Sorting_Class
    {
        Comparer _comparer = new Comparer(System.Globalization.CultureInfo.CurrentCulture);

        public decimal Compare(string x, string y)
        {
            string numxs = string.Concat(x.TakeWhile(c => char.IsDigit(c)).ToArray());
            string numys = string.Concat(y.TakeWhile(c => char.IsDigit(c)).ToArray());

            decimal xnum;
            decimal ynum;
            if (!decimal.TryParse(numxs, out xnum) || !decimal.TryParse(numys, out ynum))
            {
                return _comparer.Compare(x, y);
            }
            decimal compareNums = xnum.CompareTo(ynum);
            if (compareNums != 0)
            {
                return compareNums;
            }
            return _comparer.Compare(x, y);
        }
    }
}
