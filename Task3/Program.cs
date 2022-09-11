using System;
using System.IO;

/*  
 *  Доработайте программу из задания 1, используя ваш метод из задания 2.
    При запуске программа должна:
    Показать, сколько весит папка до очистки. Использовать метод из задания 2. 
    Выполнить очистку.
    Показать сколько файлов удалено и сколько места освобождено.
    Показать, сколько папка весит после очистки.
    C:\\Users\\admin\\Desktop\\d
 */
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = EnterPath();
            var result = CheckSize.CountFiles(path);
            Console.WriteLine("Начальный размер: " + result + " байт");
            Console.WriteLine("Выполним очистку");
            var clean = Cleaning.DeleteFiles(path);
            var newSize = CheckSize.CountFiles(clean);
            Console.WriteLine("Текущий разимер папки: " + newSize + " байт");
            long size = result - newSize;
            Console.WriteLine("Освобождено: " + size + " байт");
        }

        // Вводится путь 
        static DirectoryInfo EnterPath()
        {
            Console.WriteLine("Введите путь до папки, например C:\\Users\\Lenovo\\OneDrive\\Рабочий стол\\SkillFactory");
            string path = Console.ReadLine();
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            return dirInfo;
        }


    }
}
