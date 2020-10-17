using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson4 //Антипов Никита
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.
            //Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  
            //целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  
            //Написать программу, позволяющую найти и вывести количество пар элементов массива, 
            //в которых только одно число делится на 3. В данной задаче под парой подразумевается 
            //два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

            //MyArray Arr = new MyArray(10, -10, 10);

            //Console.WriteLine(Arr.ToString());
            //Console.WriteLine(Arr.Couple);
            //Console.ReadLine();
            #endregion

            #region 2.
            //Реализуйте задачу 1 в виде статического класса StaticClass;
            //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            //б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
            //в)**Добавьте обработку ситуации отсутствия файла на диске.

            //a.
            //Array.Ar = Array.GetArray(10, -10, 10);

            //Console.WriteLine(Array.ToStr());
            //Console.WriteLine(Array.Coup(Array.Ar));
            //Console.ReadLine();



            //б, в.
            try
            {
                Reader();
                Write();
            }
            catch
            {
                Console.WriteLine("Файл не найден.");
            }

            Console.ReadLine();
            #endregion
        }

        private static void Reader()
        {
            using(StreamReader sr = new StreamReader(@"C:\Users\admin\Desktop\C#\Lesson4(HW)Text.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    
                    Console.WriteLine($"{s}");
                }
              
            }
        }

        private static void Write()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\admin\Desktop\C#\Lesson4\Text.txt");
            sw.WriteLine("6");
            sw.WriteLine("7");
            sw.WriteLine("8");
            sw.WriteLine("9");
            sw.WriteLine("10");
            sw.Close();
        }
    }
}
