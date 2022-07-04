using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dewery_Decimal_System_19001700
{
    class Books
    {
        //public decimal Number { get; set; }
        //public string Auth { get; set; }

        public decimal Number;
        public string Auth;

        public Books (decimal Number, String Auth)
        {
            this.Number = Number;
            this.Auth = Auth;
        }
        
        public decimal GetNumber()
        {
            return Number;
        }

        public void SetNumber()
        {
            this.Number = Number;
        }


        public string GetAuth()
        {
            return Auth;
        }
        public void SetAuth()
        {
            this.Auth = Auth;
        }

        public override string ToString()
        {
           string zeroSpace = string.Empty;
           if (Number <= 9)
           {
                zeroSpace = "00";
           }
           else if (Number <= 99)
            {
                zeroSpace = "0";
            }
            return zeroSpace + Number + " " + Auth;
        }


    }
}
