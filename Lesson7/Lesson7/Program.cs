using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*ACoder class test*/
            Console.WriteLine("#--ACoder class test--#");

            ACoder aCoder = new ACoder();

            string sourceText = "Артур";
            Console.WriteLine("Source text: {0}", sourceText);

            string сoderEncodedText = aCoder.Encode(sourceText);
            Console.WriteLine("Encoded text: {0}", сoderEncodedText);

            string сoderDecodedText = aCoder.Decode(сoderEncodedText);
            Console.WriteLine("Decoded text: {0}", сoderDecodedText);

            /*BCoder class test*/
            Console.WriteLine("\n\n#--BCoder class test--#");

            BCoder bCoder = new BCoder();

            sourceText = "АРТУР";
            Console.WriteLine("Source text: {0}", sourceText);

            сoderEncodedText = bCoder.Encode(sourceText);
            Console.WriteLine("Encoded text: {0}", сoderEncodedText);

            сoderDecodedText = bCoder.Decode(сoderEncodedText);
            Console.WriteLine("Decoded text: {0}", сoderDecodedText);

            Console.Read();


        }
    }
}
