using System;

namespace ParseNameAndEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            //Чтение, анализ и преобразование содержимого файла в массив строк
            var strAr = WorkingClass.ReadFromFile("NameEmail.txt");
            strAr = WorkingClass.ParseStringArr(strAr);
            foreach (var s in strAr)
            {
                Console.WriteLine(s);
            }

            //сохранение в файл
            WorkingClass.WriteToFile(strAr, "Email.txt");

        }
    }
}
