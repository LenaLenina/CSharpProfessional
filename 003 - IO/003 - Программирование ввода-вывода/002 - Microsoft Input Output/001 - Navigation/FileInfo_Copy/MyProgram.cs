using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileInfo_Copy
{
    class MyProgram
    {
        public static void Run()
        {
            var file = new FileInfo(@"C:\Windows\notepad.exe");

            try
            {
                file.CopyTo(@"D:\notepad.exe");
                Console.WriteLine("Success copy");
            }
            catch (Exception ez)
            {
                Console.WriteLine(ez.Message);
            }
        }
    }
}
