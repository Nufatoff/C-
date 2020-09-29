using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        
        
            //3.
            //static bool Odd(int a)
            //{
            //    return (a % 2 != 0 && a > 0);             
            //}


            //4.
            //static bool Check(string l, string p)
            //{
            //    return (l == "root" && p == "GeekBrains");
            //}


            //6.
            //static int SumNumber(int k)
            //{
            //    int sum = 0;
            //    while (k != 0)
            //    {
            //        sum = sum + k % 10;
            //        k = k / 10;
            //    }
            //    return sum;
            //}
            //static bool GoodNum(int a, int b)
            //{
            //    return a % b == 0;
            //}


            //7.
            //static void Recursive(int a, int b, int sum)
            //{

            //    if (a <= b)          
            //    {
            //        sum = sum + a;
            //        Console.WriteLine($"{a,5} {sum,10}");
            //        Recursive(a + 1, b, sum);

            //    }                 
            //}


            static void Main(string[] args)
            {
                #region 1.

                //1. Написать метод, возвращающий минимальное из трёх чисел.

                //Console.WriteLine("Введите целое положительное число: ");
                //Console.Write("Первое: ");
                //int a = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Второе: ");
                //int b = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Третье: ");
                //int c = Convert.ToInt32(Console.ReadLine());
                //int min = 0;

                //if (a < b && a < c) min = a;
                //else if (b < c) min = b;
                //else min = c;
                //Console.WriteLine($"min = {min}");
                //Console.ReadLine();

                #endregion

                #region 2.

                //2. Написать метод подсчета количества цифр числа.

                //Console.Write("Введите число: ");
                //uint num = Convert.ToUInt32(Console.ReadLine());
                //uint num2 = num;
                //uint amount = 0;
                //while (num2 != 0)
                //{
                //    num2 = num2 / 10;
                //    amount++;
                //}
                //Console.WriteLine($"Количество цифр числа {num} = {amount}");
                //Console.ReadLine();

                #endregion

                #region 3.

                //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

                //Console.WriteLine("Введите целое число: ");
                //int num = Convert.ToInt32(Console.ReadLine());
                //int sum = 0;

                //while (num != 0)
                //{
                //    if(Odd(num))
                //        sum = sum + num;
                //    num = Convert.ToInt32(Console.ReadLine());

                //}
                //Console.WriteLine($"Сумма введённых чисел = {sum}");
                //Console.ReadLine();

                #endregion

                #region 4.

                //4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
                //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
                //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
                //программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

                //string log, pas;
                //int count = 0;
                //do
                //{
                //    Console.Write("Логин: ");
                //    log = (string)Console.ReadLine();
                //    Console.Write("Пароль: ");
                //    pas = (string)Console.ReadLine();
                //    count++;
                //    if (Check(log, pas))
                //    {
                //        Console.WriteLine("Доступ разрешён.");
                //        break;
                //    }

                //    else if (count == 3)
                //    {
                //        Console.WriteLine("Вы ошиблись три раза. Попробуйте авторизоваться позже.");
                //        break;
                //    }

                //    else
                //        Console.WriteLine("Неверный логин или пароль. Попробуйте ещё раз. ");

                //} 
                //while (count < 3);
                //Console.ReadLine();   

                #endregion

                #region 5.

                //5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
                //нужно ли человеку похудеть, набрать вес или всё в норме.
                //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

                //Console.Write("Рост (в метрах): ");
                //double h = double.Parse(Console.ReadLine());
                //Console.Write("Вес: ");
                //double m = double.Parse(Console.ReadLine());
                //double i = m / Math.Pow(h, 2);
                //Console.WriteLine($"Индекс массы тела: {i:F2}");

                //if (i <= 16) Console.WriteLine("Выраженный дефицит массы тела.");
                //if (i > 16 && i <= 18.5) Console.WriteLine("Недостаточная (дефицит) масса тела.");
                //if (i > 18.5 && i <= 25) Console.WriteLine("Норма.");
                //if (i > 25 && i <= 30) Console.WriteLine("Избыточная масса тела (предожирение).");
                //if (i > 30 && i <= 35) Console.WriteLine("Ожирение.");
                //if (i > 35 && i <= 40) Console.WriteLine("Ожирение резкое.");
                //Console.ReadLine();

                #endregion

                #region 6.

                //6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
                //«Хорошим» называется число, которое делится на сумму своих цифр. 
                //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

                //DateTime TimeStart = DateTime.Now;
                //int n = 100000;
                //int sum = 0;
                //int amount = 0;
                //for (int i = 1; i <= n; i++)
                //{
                //    sum = SumNumber(i);
                //    if (GoodNum(i, sum))
                //    {
                //        amount++;
                //        Console.WriteLine($" {amount} {i, 10} {sum, 10}");

                //    }                

                //}
                //Console.WriteLine(TimeStart - DateTime.Now);
                //Console.ReadLine();

                #endregion

                #region 7.

                //7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
                //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

                //Console.Write("a = ");
                //int a = int.Parse(Console.ReadLine());
                //Console.Write("b = ");
                //int b = int.Parse(Console.ReadLine());
                ////Recursive(a, b);
                //int sum = 0;
                //Recursive(a, b, sum);
                //Console.ReadLine();

                #endregion
            }
        }
}
