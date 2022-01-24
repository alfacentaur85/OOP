using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson7.Interfaces;

namespace Lesson7
{
    public sealed class ACoder : ICoder
    {
        public string Decode(string textForEncoding)
        {
            string result = "";
            int strLength = textForEncoding.Length;
            for (int i = 0; i < strLength; i++)
            {
                result += Convert.ToChar((int)textForEncoding[i] - 1);
            }
            return result;
        }

        public string Encode(string textForEncoding)
        {
            string result = "";
            int strLength = textForEncoding.Length;
            for (int i = 0; i < strLength; i++)
            {
                result += Convert.ToChar((int)textForEncoding[i] + 1);
            }
            return result;
        }
    }
}
