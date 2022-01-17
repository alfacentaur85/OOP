using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ParseNameAndEmail
{
    public static class WorkingClass
    {
        public static string[] ReadFromFile(string fileName)
        {
            string textFromFile = "";
            // чтение из файла
            using (FileStream fstream = File.OpenRead($"{fileName}"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                textFromFile = System.Text.Encoding.Default.GetString(array);
            }
            return textFromFile.Split('\n');
        }

        public static string[] ParseStringArr(string[] strArr)
        {
            List<string> result = new List<string>();
            foreach (string s in strArr)
            {
                var index = s.IndexOf('&');
                if (index != -1 && index < s.Length)
                    result.Add(s.Substring(index + 1));
            }
            return result.ToArray();
        }

        public static void WriteToFile(string[] strArr, string fileName)
        {
            using (FileStream fstream = new FileStream($"{fileName}", FileMode.OpenOrCreate))
            {
                fstream.SetLength(0);
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(String.Join('\n', strArr));
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
        }
    }
}
