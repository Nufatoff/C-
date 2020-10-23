using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_HomeWork_ //Антипов Никита
{
    #region 1.a.
    //struct Complex
    //{
    //    public double im;
    //    public double re;

    //    public Complex Minus(Complex x)
    //    {
    //        Complex y;
    //        y.im = im - x.im;
    //        y.re = re - x.re;
    //        return y;
    //    }

    //    public string ToString()
    //    {
    //        return re + "+" + im + "i";
    //    }
    //}
    #endregion

    #region 1.б.
    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        //    public double im;
        //    public double re;

        //    public Complex Minus(Complex x2)
        //    {
        //        Complex x3 = new Complex();
        //        x3.im = x2.im - this.im;
        //        x3.re = x2.re - this.re;
        //        return x3;
        //    }
        //    public Complex Multi(Complex x)
        //    {
        //        Complex y = new Complex();
        //        y.im = re * x.im + im * x.re;
        //        y.re = re * x.re - im * x.im;
        //        return y;
        //    }

        //    public string ToString()
        //    {
        //        return re + "+" + im + "i";
        //    }
        //}

        #endregion




        class Program       
        {

            //2.
            static bool Odd(int a)
            {
                return (a % 2 == 1 && a > 0);
            }

            static void Main(string[] args)
            {

                //1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
                //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
                //в) Добавить диалог с использованием switch демонстрирующий работу класса.

                #region 1.а.

                //Complex complex1 = new Complex();
                //complex1.re = 3;
                //complex1.im = 3;

                //Complex complex2 = new Complex();
                //complex2.re = 2;
                //complex2.im = 2;

                //Complex result = complex1.Minus(complex2);
                //Console.WriteLine(result.ToString());
                //Console.ReadLine();

                #endregion

                #region 1.б.
                //Complex complex1 = new Complex();
                //complex1.re = 1;
                //complex1.im = 1;

                //Complex complex2 = new Complex();
                //complex2.re = 2;
                //complex2.im = 2;

                //Complex result = complex1.Minus(complex2);
                //Console.WriteLine(result.ToString());
                //result = complex1.Multi(complex2);
                //Console.WriteLine(result.ToString());

                //Console.ReadLine();
                #endregion

                #region 2.
                //С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).
                //Требуется подсчитать сумму всех нечётных положительных чисел. 
                //Сами числа и сумму вывести на экран, используя tryParse.

                Console.WriteLine("Введите целое число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                int i;
                while (num != 0)
                {
                    if (Odd(num))
                        sum += num;
                    num = Convert.ToInt32(Console.ReadLine(), out i);
                    
                }
                Console.WriteLine($"Сумма нечётных чисел: {sum}");
                Console.ReadLine();

                #endregion

            }
        }   
    
      }
}
