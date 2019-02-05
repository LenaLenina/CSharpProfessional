using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions3
{
    public class MyProgram
    {
        public static void Met()
        {
            string pattern;

            pattern = @"^\d*\D+\d+$"; // "23"


            var regex = new Regex(pattern);

            // Массив строк для сравнения.
            var array = new[] { "test", "123", "test123", "123test", "te123st", "4556yyy789" };

            foreach (String element in array)
            {
                Console.WriteLine(
                    regex.IsMatch(element)
                        ? "Строка \"{0}\" соответствует шаблону \"{1}\""
                        : "Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", element, pattern);

                Console.WriteLine(new string('-', 50));
            }


        }
    }
}
