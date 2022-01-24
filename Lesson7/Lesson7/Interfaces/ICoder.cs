using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7.Interfaces
{
    public interface ICoder
    {
        public string Encode(string textForEncoding);
        public string Decode(string textForEncoding);
    }
}
