using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegularExpressions5
{
    class MyProgram
    {
        public static void Met()
        {
            Regex regex;
            string pattern;
            string text;

            pattern = "^[qwerty]+$";
            text = "qwec";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            pattern = "^[qwerty]+$";
            text = "qwere";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            pattern = "^[abcdefghigklmnopqrstuvwxyz]+$";
            text = "test"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Второй способ, a-z это замена более длинного шаблона abcdefghigklmnopqrstuvwxyz
            pattern = @"^[a-z]+$";
            text = "test"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // 0-9 это замена 01234567890.
            pattern = "^[a-z0-9]+$";
            text = "test007"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // 0-9 это замена 01234567890.
            pattern = "^[a-z0-9]+\\s[a-z0-9]+$";
            text = "test 007"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Шаблон даты.
            pattern = @"^\d{2}-\d{2}-\d{4}$";
            text = "02-05-1982"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Квантификатор * значит, что вхождение 0 и более раз...
            pattern = @"^\d*$";
            text = "ertty"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Квантификатор * значит, что вхождение 0 и более раз...
            pattern = @"^\d*$";
            text = ""; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Простой шаблон сравнения e-mail.
            pattern = @"^[0-9a-z_-]+@[\S]+\.\S{2,4}$";
            text = "test@mail123.rлu"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

        }
    }
}
