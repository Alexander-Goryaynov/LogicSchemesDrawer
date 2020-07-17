using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSchemesDrawer
{
    public class MyConverter
    {
        public int ToDecimalSystem(string num, int systemBase)
        {
            char[] a = num.ToCharArray();
            int result = 0;
            int power = 1;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if ((a[i] > 64) && (a[i] < 70)) // if capital letter
                {
                    result += (Convert.ToInt32(a[i]) - 55) * power;
                }
                else
                {
                    result += (Convert.ToInt32(a[i]) - 48) * power;
                }
                power *= systemBase;
            }
            return result;
        }

        public string DecimalToXSystem(int num, int x)
        {
            string number = "";
            while (num >= x)
            {
                if (num % x > 9)
                {
                    number += (char)((num % x) + 55);
                }
                else
                {
                    number += num % x;
                }
                num /= x;
            }
            if (num > 9)
            {
                number += (char)(num + 55);
            }
            else
            {
                number += num;
            }
            return ReverseString(number);
        }

        private string ReverseString(string s)
        {
            char[] a = s.ToCharArray();
            Array.Reverse(a);
            return new string(a);
        }
    }
}
