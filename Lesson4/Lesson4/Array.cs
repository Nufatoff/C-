using System;

namespace Lesson4 //Антипов Никита
{
    //Задача 2.
    static class Array
    {
        //a.
        public static int[] Ar;
        
        public static int[] GetArray(int n, int min, int max)
        {
            Ar = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                Ar[i] = rnd.Next(min, max);
            return Ar;
        }

        public static int Coup(int[] ar)
        {
            
            int count = 0;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] % 3 == 0 && ar[i + 1] % 3 != 0)
                    count++;
                else
                {
                    if (ar[i] % 3 != 0 && ar[i + 1] % 3 == 0)
                        count++;
                }

            }
            return count;           

        }

        public static string ToStr()
        {
            string s = "";
            foreach (int v in Ar)
                s = s + v + "\n";
            return s;
        }

    }
}
