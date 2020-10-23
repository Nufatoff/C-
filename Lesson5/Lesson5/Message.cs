using System;
using System.Linq;
using System.Text;

namespace Lesson5
{
    static class Message
    {
        /// <summary>
        /// Поиск слов (<=n).
        /// </summary>
        /// <param name="n">Количество букв</param>
        /// <param name="text"></param>
        public static void Leng(int n, string text)
        {
            char[] div = { ' ', ',', '.', '!', '?', '-' };
            string[] msv = text.Split(div);
            for (int i = 0; i < msv.Length; i++)
            {
                if (msv[i].Length <= n)
                {
                    Console.WriteLine(msv[i]);
                }
            }
        }

        /// <summary>
        /// Удаление слов, оканчивающихся на заданный символ.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="letter"></param>
        public static void Excess(string text, string letter)
        {
            char[] div = { ' ', ',', '.', '!', '?', '-' };
            string[] msv = text.Split(div);
            for (int i = 0; i < msv.Length; i++)
            {
                if (msv[i].EndsWith(letter))
                {
                    msv = msv.Where(val => val != msv[i]).ToArray();
                }
            }
            foreach (var e in msv)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Поиск самого длинного слова.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static StringBuilder MaxLengthLetter(string text)
        {
            char[] div = { ' ', ',', '.', '!', '?', '-', ':', ';' };
            string[] msv = text.Split(div, StringSplitOptions.RemoveEmptyEntries);
            int max = msv[0].Length;
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < msv.Length; i++)
            {
                if (msv[i].Length > max)
                {
                    max = msv[i].Length;                    
                }                              
            }
            for (int i = 0; i < msv.Length; i++)
            {
                if (msv[i].Length == max)
                {
                    str.Append(msv[i] + " ");
                }
            }
                
            return str;
        }

    }
}
