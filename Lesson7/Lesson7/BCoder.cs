using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson7.Interfaces;
using Lesson7.Core;

namespace Lesson7 
{
    public sealed class BCoder : ICoder
    {
        public string Decode(string textForEncoding)
        {
            textForEncoding = textForEncoding.ToUpper();

            string result = "";

            int oldOrder = 0;

            int newOrder = 0;

            int strLength = textForEncoding.Length;
            for (int i = 0; i < strLength; i++)
            {
                oldOrder = Core.Core.Alphabet[textForEncoding[i]];

                newOrder = Core.Core.Alphabet.Count - oldOrder + 1;

                foreach (KeyValuePair<char, int> kvp in Core.Core.Alphabet)
                {
                    if (kvp.Value == newOrder)
                    {
                        result += kvp.Key;
                        break;
                    }
                }
            }
            return result;
        }

       public string Encode(string textForEncoding)
        {
            textForEncoding = textForEncoding.ToUpper();

            string result = "";

            int oldOrder = 0;

            int newOrder = 0;

            int strLength = textForEncoding.Length;
            for (int i = 0; i < strLength; i++)
            {
                oldOrder = Core.Core.Alphabet[textForEncoding[i]];

                newOrder = Core.Core.Alphabet.Count - oldOrder + 1;

                foreach (KeyValuePair<char, int> kvp in Core.Core.Alphabet)
                {
                    if (kvp.Value == newOrder)
                    {
                        result += kvp.Key;
                        break;
                    }
                }
            }
            return result;

        }
    }
}
