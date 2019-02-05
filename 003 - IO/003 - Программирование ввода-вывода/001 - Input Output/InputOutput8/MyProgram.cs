using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InputOutput8
{
    class MyProgram
    {
        public static void Method()
        {
            var memory = new MemoryStream();

            memory.Capacity = 256;

            for (int i = 0; i < 256; i++)
            {
                memory.WriteByte((byte)i);
            }

            memory.Position = 0;

            for (int i = 0; i < 256; i++)
            {
                Console.Write(" " + memory.ReadByte());
            }

            Console.WriteLine("\n" + new string('-',80));

            byte[] array = memory.ToArray();

            foreach (byte b in array)
            {
                Console.Write(b + " ");
            }

            Console.WriteLine("\n" + new string('-', 80));

            var file = new FileStream("MyDump.dat",FileMode.Create,FileAccess.ReadWrite);
            memory.WriteTo(file);

            file.Position = 0;

            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine(" " + file.ReadByte());
            }

            memory.Close();
            file.Close();
        }
    }
}
