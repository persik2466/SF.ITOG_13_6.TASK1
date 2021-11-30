using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SF.ITOG_13_6.TASK1_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Читаем весь файл с рабочего стола
            string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Text1.txt");

            //Создаём список List
            List<string> linesList = new List<string>();

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { '\r', '\n' }; 

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var myStrings = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // запускаем новый таймер
            var stopWatch = Stopwatch.StartNew();

            //Добавляем строки в список List<T> 
            foreach (var item in myStrings)
            {
                linesList.Add(item);
                //Console.WriteLine(item);
            }
            //Смотрим, сколько операция заняла, в миллисекундах в среднем - 0.4862 мс
            Console.WriteLine("Добавление текста в список List заняло " + stopWatch.Elapsed.TotalMilliseconds + " мс.");

            Console.ReadKey();
        }
    }
}