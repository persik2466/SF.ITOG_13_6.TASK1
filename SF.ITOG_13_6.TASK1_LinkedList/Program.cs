using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SF.ITOG_13_6.TASK1_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Читаем весь файл с рабочего стола
            string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Text1.txt");

            //Создаём список LinkedList
            LinkedList<string> linesLinkedList = new LinkedList<string>();

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] {'\r', '\n'};  

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var myStrings = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // запускаем новый таймер
            var stopWatch = Stopwatch.StartNew();
            
            //Добавляем строки в список List<T> 
            foreach (var item in myStrings)
            {
                linesLinkedList.AddLast(item);
                //Console.WriteLine(item);
            }
            //Смотрим, сколько операция заняла, в миллисекундах в среднем - 0.7642 мс
            Console.WriteLine("Добавление текста в список LinkedList заняло " + stopWatch.Elapsed.TotalMilliseconds + " мс.");

            Console.ReadKey();
        }
    }
}
