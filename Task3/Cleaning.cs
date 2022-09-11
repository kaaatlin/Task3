using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    public static class Cleaning
    {
        // Удаление папок
        public static DirectoryInfo DeleteFiles(DirectoryInfo path)
        {
            // Проверка существования директории по заданному пути
            if (path.Exists)
            {
                DirectoryInfo[] dirs = path.GetDirectories();
                FileInfo[] file = path.GetFiles();
                Console.WriteLine("Сейчас произойдет удаление");
                DateTime LastAccess;

                foreach (FileInfo files in file)
                {
                    LastAccess = files.LastWriteTime;

                    if (DateTime.Now.AddMinutes(-30) >= LastAccess)
                    {
                        files.Delete();
                        Console.WriteLine($"Файл {files} удален");
                    }
                }

                foreach (DirectoryInfo dir in dirs)
                {
                    //Получаем информацию о том, когда последний раз проводили работу с папками или файлами
                    LastAccess = dir.LastWriteTime;
                    if (DateTime.Now.AddMinutes(-30) >= LastAccess)
                    {
                        dir.Delete();
                        Console.WriteLine($"Папка {dir} удалена");
                    }
                    DeleteFiles(dir);
                }
            }
            return path;
        }
    }
}
