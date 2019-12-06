using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] {' ', '.', '?', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static String Capitalize(this String str)
        {
            string first = str[0].ToString().ToUpper();
            return first + str.Substring(1);
        }
        //this does not work
        public static void Decapitalize(this String str)
        {
            string first = str[0].ToString().ToLower();
            str = first + str.Substring(1);
        }

        public static String Titlize(this String title)
        {
            List<string> articles = new List<string>()
            {
                "a",
                "an",
                "the"
            };
            List<string> parts = new List<string>(title.Split(" "));

            if (articles.Contains(parts[0].ToLower()))
            {
                string first = parts[0];
                parts.RemoveAt(0);
                parts.Add(", " + first); ;
                parts.Add(first);
                first = parts[0];
                while (articles.Contains(first.ToLower()))
                {
                    parts.RemoveAt(0);
                    parts.Add(" ");
                    parts.Add(first);
                    first = parts[0];
                }
                
            }

            string result = "";
            foreach (string s in parts)
            {
                result += s + " ";
            }
            return result;

        }
    }
}
