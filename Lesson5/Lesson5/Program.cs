using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson5
{
    class Program
    {
        //1,a.
        private static void Check(char[] userLog)
        {
            
            if (userLog.Length < 2)
            {

                Console.WriteLine("Логин слишком короткий.\n ");

            }

            else if (userLog.Length > 10)
            {
                Console.WriteLine("Логин слишком длинный.\n ");

            }

            else
            {
                if (Char.IsDigit(userLog[0]))
                {
                    Console.WriteLine("Логин не может начинаться с цифры.\n");

                }


                else
                {
                    for (int i = 0; i < userLog.Length; i++)
                    {
                        char[] arr = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=' };

                        for (int j = 0; j < arr.Length; j++)
                        {
                            if (userLog[i] >= 'а' && userLog[i] <= 'я' || userLog[i] >= 'А' && userLog[i] <= 'Я' || userLog[i] == 'ё' || userLog[i] == 'Ё')
                            {
                                Console.WriteLine("Логин не может содержать буквы русского алфавита.\n");

                                break;
                            }

                            else if (userLog[i] == arr[j])
                            {
                                Console.WriteLine("Логин не может содержать спецсимволы.\n");

                                break;
                            }

                            else if (userLog[i] >= 'a' && userLog[i] <= 'z' || userLog[i] >= 'A' && userLog[i] <= 'Z' || userLog[i] >= '0' && userLog[i] <= '9')
                            {
                                Console.WriteLine("Логин соответсвует требованиям.\n");

                                break;

                            }

                            break;
                        }

                        break;
                    }

                }
            }

        }


        static void Main(string[] args)
        {
            #region 1.
            //Создать программу, которая будет проверять корректность ввода логина. 
            //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы 
            //латинского алфавита или цифры, при этом цифра не может быть первой:
            //а) без использования регулярных выражений;
            //б) **с использованием регулярных выражений.

            //a.
            //Console.Write("Введите логин от 2 до 10 символов\n(Логин может содержать только буквы латинского алфавита или цифры): ");

            //char[] userLog = Console.ReadLine().ToCharArray();

            //Check(userLog);


            //б
            ////string log = new string(userLog);
            //string log = Convert.ToString(Console.ReadLine());
            //Regex reg = new Regex(@"[A-Za-z]{1}([A-Za-z0-9][^!@#$%^&*();:%?*=_+{}|\/><]){1,9}");
            //Console.WriteLine(reg.IsMatch(log));
            //Console.ReadLine();
            #endregion

            #region 2.
            //2.Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            //а) Вывести только те слова сообщения,  которые содержат не более n букв.
            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            //в) Найти самое длинное слово сообщения.
            //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            //д) ***Создать метод, который производит частотный анализ текста.В качестве параметра 
            //в него передается массив слов и текст, в качестве результата метод возвращает 
            //сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.

            //string str = "дана строка, в которой содержится осмысленное текстовое сообщение. Привет";
            //var msv = str.Split(new char[] { ' ', ',', '.', '!', '?', '-' }).Where(x => x.Length <= 7).ToArray();
            //foreach (var item in msv)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();


            Console.WriteLine("Введите текст: ");
            string txt = Convert.ToString(Console.ReadLine());

            //a
            Console.WriteLine("Укажите кол-во букв для поиска слов: ");
            int num = int.Parse(Console.ReadLine());
            Message.Leng(num, txt);

            //б
            //Console.WriteLine("Слова, оканчивающиеся на эту букву, будут удалены из текста: ");
            //string let = Convert.ToString(Console.ReadLine());
            string txt2 = "Шла Саша по шоссе и сосала сушку.";
            string let = "а";
            Message.Excess(txt2, let);

            //в, г
            Console.WriteLine(Message.MaxLengthLetter(txt));
            
            
            Console.ReadKey();
            #endregion
        }


    }
}
