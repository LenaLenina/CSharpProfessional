using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InputOutput9
{
    class MyProgram
    {
        public static void Method()
        {
            var file = new FileInfo("MyText.txt");

            StreamWriter writer = file.CreateText();

            writer.WriteLine("Первая строка текста...");
            writer.WriteLine("Вторая строка текста...");

            writer.WriteLine(writer.NewLine);

            writer.WriteLine("Третья строка чисел:");

            for (int i = 0; i < 10; i++)
            {
                writer.Write(i + " ");
            }

            writer.WriteLine(writer.NewLine);

            writer.Close();
        }
    }
}
