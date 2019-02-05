using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InputOutput10
{
    class MyProgram
    {
        public static void Method()
        {
            //var file2 = new FileStream("Mytext.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //var writer = new StreamWriter(file2);

            //writer.WriteLine("Первая строка текста...");

            //writer.WriteLine("Вторая строка текста...");

            //// Вставляем символ начала новой строки.
            //writer.Write(writer.NewLine);

            //writer.WriteLine("Третья строка чисел:");

            //for (int i = 0; i < 10; i++)
            //{
            //    writer.Write(i + " ");
            //}

            //// Метод Close() автоматически очищает все буферы.
            //writer.Close();

            //Console.WriteLine("Файл Text.txt создан и в него записан текст.");
            Console.WriteLine("Содержимое файла Mytext.txt:\n");

            StreamReader reader = File.OpenText("Mytext.txt");
            string input;

            while((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }

            reader.Close();
        }
    }
}
