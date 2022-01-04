using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    public static class StringUtils
    {
        public static string StringReverse(string str)
        {
            string result = "";
            if (!string.IsNullOrEmpty(str))
            {
                for(int i = str.Length - 1; i >= 0; i--)
                {
                    result += str[i];
                }
            }
            return result;
        }
    }
}
