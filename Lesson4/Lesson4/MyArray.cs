using System;

namespace Lesson4
{
    //Задача 1.
    class MyArray
    {
        int[] Arr;

        public MyArray(int n, int min, int max)
        {
            Arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                Arr[i] = rnd.Next(min, max);
        }

        public int Couple
        {
            get
            {
                int count = 0;
                for (int i = 0; i < Arr.Length - 1; i++)
                {
                    if (Arr[i] % 3 == 0 && Arr[i + 1] % 3 != 0)
                        count++;
                    else
                    {
                        if (Arr[i] % 3 != 0 && Arr[i + 1] % 3 == 0)
                            count++;
                    }
                }
                return count;
            }
        }



        public string ToString()
        {
            string s = "";
            foreach (int v in Arr)
                s = s + v + "\n";
            return s;
        }


    }
}
